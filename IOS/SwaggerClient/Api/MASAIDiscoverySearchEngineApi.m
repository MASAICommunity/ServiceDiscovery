#import "MASAIDiscoverySearchEngineApi.h"
#import "MASAIQueryParamCollection.h"
#import "MASAIApiClient.h"
#import "MASAISearchCriteria.h"
#import "MASAISearchResult.h"


@interface MASAIDiscoverySearchEngineApi ()

@property (nonatomic, strong, readwrite) NSMutableDictionary *mutableDefaultHeaders;

@end

@implementation MASAIDiscoverySearchEngineApi

NSString* kMASAIDiscoverySearchEngineApiErrorDomain = @"MASAIDiscoverySearchEngineApiErrorDomain";
NSInteger kMASAIDiscoverySearchEngineApiMissingParamErrorCode = 234513;

@synthesize apiClient = _apiClient;

#pragma mark - Initialize methods

- (instancetype) init {
    return [self initWithApiClient:[MASAIApiClient sharedClient]];
}


-(instancetype) initWithApiClient:(MASAIApiClient *)apiClient {
    self = [super init];
    if (self) {
        _apiClient = apiClient;
        _mutableDefaultHeaders = [NSMutableDictionary dictionary];
    }
    return self;
}

#pragma mark -

-(NSString*) defaultHeaderForKey:(NSString*)key {
    return self.mutableDefaultHeaders[key];
}

-(void) setDefaultHeaderValue:(NSString*) value forKey:(NSString*)key {
    [self.mutableDefaultHeaders setValue:value forKey:key];
}

-(NSDictionary *)defaultHeaders {
    return self.mutableDefaultHeaders;
}

#pragma mark - Api Methods

///
/// Search for available services at a specific location
/// The MASAI Service Discovery is a key process allowing MASAI Services to be automatically visible by travellers through the use of concierge applications.    Usage example on searching for services that discover public transport services on Nice area that integrate via api:        {        \"discoveryRequest\": [          {            \"location\": {              \"minLatitude\": 43.59491496946722,              \"minLongitude\": 7.103082476562463,              \"maxLatitude\": 43.7977308236023,              \"maxLongitude\": 7.422884722656136,              \"countries\": [                \"fr\"              ]            },            \"groupOfModule\": \"public_transport\",            \"accessKey\": \"AIzaSyD7q2VfSG9tptzWNegQMNb6lqhkuWFy_k0\",            \"providers\": [              \"google\",              \"apis\"            ],            \"serviceType\": {              \"discovery\": \"api\"            }          }        ]      }    Usage example on searching for services that book taxi services in Lisbon area that integrate via application, with price between € 5 and € 15:        {        \"discoveryRequest\": [          {            \"location\": {              \"minLatitude\": 38.699871,              \"minLongitude\": -9.172442,              \"maxLatitude\": 38.752289,              \"maxLongitude\": -9.116601,              \"countries\": [                \"pt\"              ]            },            \"price\": {              \"minPrice\": 5,              \"maxPrice\": 15            },            \"groupOfModule\": \"taxi\",            \"accessKey\": \"AIzaSyD7q2VfSG9tptzWNegQMNb6lqhkuWFy_k0\",            \"providers\": [              \"google\",              \"apis\"            ],            \"serviceType\": {              \"booking\": \"app\"            }          }        ]      }    Usage example on searching for services that book flight services in Berlin area that integrate via web page, with ratings between 2 and 5 stars:        {        \"discoveryRequest\": [          {            \"location\": {              \"minLatitude\": 52.354300665733305,              \"minLongitude\": 13.068658648437463,              \"maxLatitude\": 52.68542940506577,              \"maxLongitude\": 13.696078082031136,              \"countries\": [                \"de\"              ]            },            \"rating\": {              \"minRating\": 2,              \"maxRating\": 5            },            \"groupOfModule\": \"flight\",            \"accessKey\": \"AIzaSyD7q2VfSG9tptzWNegQMNb6lqhkuWFy_k0\",            \"providers\": [              \"google\",              \"apis\"            ],            \"serviceType\": {              \"booking\": \"web\"            }          }        ]      }
///  @param discoverApis Represent a service discovery object, used to performs search queries 
///
///  @returns MASAISearchResult*
///
-(NSURLSessionTask*) apiSearchForServiceWithDiscoverApis: (MASAISearchCriteria*) discoverApis
    completionHandler: (void (^)(MASAISearchResult* output, NSError* error)) handler {
    // verify the required parameter 'discoverApis' is set
    if (discoverApis == nil) {
        NSParameterAssert(discoverApis);
        if(handler) {
            NSDictionary * userInfo = @{NSLocalizedDescriptionKey : [NSString stringWithFormat:NSLocalizedString(@"Missing required parameter '%@'", nil),@"discoverApis"] };
            NSError* error = [NSError errorWithDomain:kMASAIDiscoverySearchEngineApiErrorDomain code:kMASAIDiscoverySearchEngineApiMissingParamErrorCode userInfo:userInfo];
            handler(nil, error);
        }
        return nil;
    }

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/api/searchForServices"];

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.apiClient.configuration.defaultHeaders];
    [headerParams addEntriesFromDictionary:self.defaultHeaders];
    // HTTP header `Accept`
    NSString *acceptHeader = [self.apiClient.sanitizer selectHeaderAccept:@[@"application/json"]];
    if(acceptHeader.length > 0) {
        headerParams[@"Accept"] = acceptHeader;
    }

    // response content type
    NSString *responseContentType = [[acceptHeader componentsSeparatedByString:@", "] firstObject] ?: @"";

    // request content type
    NSString *requestContentType = [self.apiClient.sanitizer selectHeaderContentType:@[@"application/json", @"application/x-www-form-urlencoded"]];

    // Authentication setting
    NSArray *authSettings = @[];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *localVarFiles = [[NSMutableDictionary alloc] init];
    bodyParam = discoverApis;

    return [self.apiClient requestWithPath: resourcePath
                                    method: @"POST"
                                pathParams: pathParams
                               queryParams: queryParams
                                formParams: formParams
                                     files: localVarFiles
                                      body: bodyParam
                              headerParams: headerParams
                              authSettings: authSettings
                        requestContentType: requestContentType
                       responseContentType: responseContentType
                              responseType: @"MASAISearchResult*"
                           completionBlock: ^(id data, NSError *error) {
                                if(handler) {
                                    handler((MASAISearchResult*)data, error);
                                }
                            }];
}



@end
