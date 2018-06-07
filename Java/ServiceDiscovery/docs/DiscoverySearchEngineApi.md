# DiscoverySearchEngineApi

All URIs are relative to *http://apis.masai.teleticketing.eu/ServiceDiscovery*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiSearchForService**](DiscoverySearchEngineApi.md#apiSearchForService) | **POST** /api/searchForServices | Search for available services at a specific location


<a name="apiSearchForService"></a>
# **apiSearchForService**
> SearchResult apiSearchForService(discoverApis)

Search for available services at a specific location

The MASAI Service Discovery is a key process allowing MASAI Services to be automatically visible by travellers through the use of concierge applications.    Usage example on searching for services that discover public transport services on Nice area that integrate via api:        {        \&quot;discoveryRequest\&quot;: [          {            \&quot;location\&quot;: {              \&quot;minLatitude\&quot;: 43.59491496946722,              \&quot;minLongitude\&quot;: 7.103082476562463,              \&quot;maxLatitude\&quot;: 43.7977308236023,              \&quot;maxLongitude\&quot;: 7.422884722656136,              \&quot;countries\&quot;: [                \&quot;fr\&quot;              ]            },            \&quot;groupOfModule\&quot;: \&quot;public_transport\&quot;,            \&quot;accessKey\&quot;: \&quot;AIzaSyD7q2VfSG9tptzWNegQMNb6lqhkuWFy_k0\&quot;,            \&quot;providers\&quot;: [              \&quot;google\&quot;,              \&quot;apis\&quot;            ],            \&quot;serviceType\&quot;: {              \&quot;discovery\&quot;: \&quot;api\&quot;            }          }        ]      }    Usage example on searching for services that book taxi services in Lisbon area that integrate via application, with price between € 5 and € 15:        {        \&quot;discoveryRequest\&quot;: [          {            \&quot;location\&quot;: {              \&quot;minLatitude\&quot;: 38.699871,              \&quot;minLongitude\&quot;: -9.172442,              \&quot;maxLatitude\&quot;: 38.752289,              \&quot;maxLongitude\&quot;: -9.116601,              \&quot;countries\&quot;: [                \&quot;pt\&quot;              ]            },            \&quot;price\&quot;: {              \&quot;minPrice\&quot;: 5,              \&quot;maxPrice\&quot;: 15            },            \&quot;groupOfModule\&quot;: \&quot;taxi\&quot;,            \&quot;accessKey\&quot;: \&quot;AIzaSyD7q2VfSG9tptzWNegQMNb6lqhkuWFy_k0\&quot;,            \&quot;providers\&quot;: [              \&quot;google\&quot;,              \&quot;apis\&quot;            ],            \&quot;serviceType\&quot;: {              \&quot;booking\&quot;: \&quot;app\&quot;            }          }        ]      }    Usage example on searching for services that book flight services in Berlin area that integrate via web page, with ratings between 2 and 5 stars:        {        \&quot;discoveryRequest\&quot;: [          {            \&quot;location\&quot;: {              \&quot;minLatitude\&quot;: 52.354300665733305,              \&quot;minLongitude\&quot;: 13.068658648437463,              \&quot;maxLatitude\&quot;: 52.68542940506577,              \&quot;maxLongitude\&quot;: 13.696078082031136,              \&quot;countries\&quot;: [                \&quot;de\&quot;              ]            },            \&quot;rating\&quot;: {              \&quot;minRating\&quot;: 2,              \&quot;maxRating\&quot;: 5            },            \&quot;groupOfModule\&quot;: \&quot;flight\&quot;,            \&quot;accessKey\&quot;: \&quot;AIzaSyD7q2VfSG9tptzWNegQMNb6lqhkuWFy_k0\&quot;,            \&quot;providers\&quot;: [              \&quot;google\&quot;,              \&quot;apis\&quot;            ],            \&quot;serviceType\&quot;: {              \&quot;booking\&quot;: \&quot;web\&quot;            }          }        ]      }

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DiscoverySearchEngineApi;


DiscoverySearchEngineApi apiInstance = new DiscoverySearchEngineApi();
SearchCriteria discoverApis = new SearchCriteria(); // SearchCriteria | Represent a service discovery object, used to performs search queries
try {
    SearchResult result = apiInstance.apiSearchForService(discoverApis);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DiscoverySearchEngineApi#apiSearchForService");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **discoverApis** | [**SearchCriteria**](SearchCriteria.md)| Represent a service discovery object, used to performs search queries |

### Return type

[**SearchResult**](SearchResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

