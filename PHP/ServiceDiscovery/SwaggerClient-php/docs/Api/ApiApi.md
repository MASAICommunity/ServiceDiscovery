# DiscoverySearchEngine\ApiApi

All URIs are relative to *http://apis.masai.teleticketing.eu/ServiceDiscovery*

|===
|Method | HTTP request | Description

|link:ApiApi.html#apiSearchForService[**apiSearchForService**] | **POST** /api/searchForServices | Search for available services at a specific location
|===


# **apiSearchForService**
> \DiscoverySearchEngine\DiscoverySearchEngine\SearchResult apiSearchForService($discover_apis)

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
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new DiscoverySearchEngine\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$discover_apis = new \DiscoverySearchEngine\DiscoverySearchEngine\SearchCriteria(); // \DiscoverySearchEngine\DiscoverySearchEngine\SearchCriteria | Represent a service discovery object, used to performs search queries

try {
    $result = $apiInstance->apiSearchForService($discover_apis);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->apiSearchForService: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

|===
|Name | Type | Description  | Notes

| **discover_apis** | link.../Model/SearchCriteria.html[**\DiscoverySearchEngine\DiscoverySearchEngine\SearchCriteria**]| Represent a service discovery object, used to performs search queries |
|===

### Return type

link:../Model/SearchResult.html[**\DiscoverySearchEngine\DiscoverySearchEngine\SearchResult**]

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

link:#[[Back to top]] link:../../README.html#documentation-for-api-endpoints[[Back to API list]] link:../../README.html#documentation-for-models[[Back to Model list]] link:../../README.html[[Back to README]]

