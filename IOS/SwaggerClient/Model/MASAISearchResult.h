#import <Foundation/Foundation.h>
#import "MASAIObject.h"

/**
* MASAI Service Discovery API
* No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
*
* OpenAPI spec version: v1
* 
*
* NOTE: This class is auto generated by the swagger code generator program.
* https://github.com/swagger-api/swagger-codegen.git
* Do not edit the class manually.
*/


#import "MASAISearchResponse.h"
@protocol MASAISearchResponse;
@class MASAISearchResponse;



@protocol MASAISearchResult
@end

@interface MASAISearchResult : MASAIObject

/* Service information per group of module [optional]
 */
@property(nonatomic) NSDictionary<MASAISearchResponse>* searchResponses;
/* Service error message [optional]
 */
@property(nonatomic) NSString* message;
/* Status information [optional]
 */
@property(nonatomic) NSString* status;
/* Timer information for each search engine [optional]
 */
@property(nonatomic) NSArray<NSString*>* timers;

@end
