# MASAIDiscoverySearchEngineApi

All URIs are relative to *http://apis.masai.teleticketing.eu/ServiceDiscovery*

|===
|Method | HTTP request | Description

|link:MASAIDiscoverySearchEngineApi.html#apisearchforservice[**apiSearchForService**] | **POST** /api/searchForServices | Search for available services at a specific location
|===


# **apiSearchForService**
```objc
-(NSURLSessionTask*) apiSearchForServiceWithDiscoverApis: (MASAISearchCriteria*) discoverApis
        completionHandler: (void (^)(MASAISearchResult* output, NSError* error)) handler;
```

Search for available services at a specific location

The MASAI Service Discovery is a key process allowing MASAI Services to be automatically visible by travellers through the use of concierge applications.    Usage example on searching for services that discover public transport services on Nice area that integrate via api:

{
	"discoveryRequest": [{
			"location": {
				"minLatitude": 43.59491496946722,
				"minLongitude": 7.103082476562463,
				"maxLatitude": 43.7977308236023,
				"maxLongitude": 7.422884722656136,
				"countries": ["fr"]
			},
			"groupOfModule": "public_transport",
			"accessKey": "AIzaSyD7q2VfSG9tptzWNegQMNb6lqhkuWFy_k0",
			"providers": ["google", "apis"],
			"serviceType": {
				"discovery": "api"
			}
		}
	]
}

Usage example on searching for services that book taxi services in Lisbon area that integrate via application, with price between € 5 and € 15: 

{
	"discoveryRequest": [{
			"location": {
				"minLatitude": 38.699871,
				"minLongitude": -9.172442,
				"maxLatitude": 38.752289,
				"maxLongitude": -9.116601,
				"countries": ["pt"]
			},
			"price": {
				"minPrice": 5,
				"maxPrice": 15
			},
			"groupOfModule": "taxi",
			"accessKey": "AIzaSyD7q2VfSG9tptzWNegQMNb6lqhkuWFy_k0",
			"providers": ["google", "apis"],
			"serviceType": {
				"booking": "app"
			}
		}
	]
}

Usage example on searching for services that book flight services in Berlin area that integrate via web page, with ratings between 2 and 5 stars: 

{
	"discoveryRequest": [{
			"location": {
				"minLatitude": 52.354300665733305,
				"minLongitude": 13.068658648437463,
				"maxLatitude": 52.68542940506577,
				"maxLongitude": 13.696078082031136,
				"countries": ["de"]
			},
			"rating": {
				"minRating": 2,
				"maxRating": 5
			},
			"groupOfModule": "flight",
			"accessKey": "AIzaSyD7q2VfSG9tptzWNegQMNb6lqhkuWFy_k0",
			"providers": ["google", "apis"],
			"serviceType": {
				"booking": "web"
			}
		}
	]
}


### Example 
```objc

MASAISearchCriteria* discoverApis = [[MASAISearchCriteria alloc] init]; // Represent a service discovery object, used to performs search queries

MASAIDiscoverySearchEngineApi*apiInstance = [[MASAIDiscoverySearchEngineApi alloc] init];

// Search for available services at a specific location
[apiInstance apiSearchForServiceWithDiscoverApis:discoverApis
          completionHandler: ^(MASAISearchResult* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling MASAIDiscoverySearchEngineApi->apiSearchForService: %@", error);
                        }
                    }];
```

### Parameters

|===
|Name | Type | Description  | Notes

| **discoverApis** | link:MASAISearchCriteria.html[**MASAISearchCriteria***]| Represent a service discovery object, used to performs search queries | 
|===

### Return type

link:MASAISearchResult.html[**MASAISearchResult***]

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

link:#[[Back to top]] link:../README.html#documentation-for-api-endpoints[[Back to API list]] link:../README.html#documentation-for-models[[Back to Model list]] link:../README.html[[Back to README]]

