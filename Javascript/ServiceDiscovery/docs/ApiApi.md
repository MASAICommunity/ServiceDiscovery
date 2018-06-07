# DiscoverySearchEngine.ApiApi

All URIs are relative to *http://apis.masai.teleticketing.eu/ServiceDiscovery*

|===
|Method | HTTP request | Description

|link:ApiApi.html#apiSearchForService[**apiSearchForService**] | **POST** /api/searchForServices | Search for available services at a specific location
|===


# anchor:apiSearchForService[]**apiSearchForService**
> SearchResult apiSearchForService(discoverApis)

Search for available services at a specific location

The MASAI Service Discovery is a key process allowing MASAI Services to be automatically visible by travellers through the use of concierge applications.    Usage example on searching for services that discover public transport services on Nice area that integrate via api:        
```
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
```javascript
var DiscoverySearchEngine = require('masai_service_discovery_api');

var apiInstance = new DiscoverySearchEngine.ApiApi();

var discoverApis = new DiscoverySearchEngine.SearchCriteria(); // SearchCriteria | Represent a service discovery object, used to performs search queries


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.apiSearchForService(discoverApis, callback);
```

### Parameters

|===
|Name | Type | Description  | Notes

| **discoverApis** | link:SearchCriteria.html[**SearchCriteria**]| Represent a service discovery object, used to performs search queries | 
|===

### Return type

link:SearchResult.html[**SearchResult**]

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

