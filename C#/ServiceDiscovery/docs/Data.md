# ServiceDiscovery.Model.Data
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PlanConditions** | **string** | Plan conditions of the service | [optional] 
**Swagger** | [**SwaggerDocument**](SwaggerDocument.md) | Swagger file information | [optional] 
**Properties** | [**List&lt;Properties&gt;**](Properties.md) | Properties service information | [optional] 
**Contact** | [**List&lt;Contact&gt;**](Contact.md) | Contact service information | [optional] 
**Maintainers** | [**List&lt;Maintainers&gt;**](Maintainers.md) | Maintainers service informatoin | [optional] 
**Tags** | **List&lt;string&gt;** | Tags service information | [optional] 
**IntegrationMode** | **string** | Information related to how the service is integrated | [optional] 
**LevelOfService** | **List&lt;string&gt;** | Level of service provided | [optional] 
**Name** | **string** | Name of the service | [optional] 
**Description** | **string** | Description of the service | [optional] 
**Image** | **string** | Image related of the service | [optional] 
**BaseURL** | **string** | Base URL of the service | [optional] 
**HumanURL** | **string** | URL of the human readable documentation | [optional] 
**AppName** | **string** | App name of the service if the integration mode is \&quot;app\&quot;. E.g.: \&quot;Travel Concierge\&quot; | [optional] 
**PackageName** | **string** | Package name of the service if the integration mode is \&quot;app\&quot;. E.g.: \&quot;com.serviceprovider.travelconcierge\&quot; | [optional] 
**DeeplinkURL** | **string** | Base deeplink URL of the service to integrate directly with application. (This attribute will appear only if integration mode is \&quot;app\&quot;.) | [optional] 
**PlanConditionsUrl** | **string** | Plan conditions URL with human readable information | [optional] 
**UpdatedAt** | **string** | Timestamp of when service was updated | [optional] 
**SignatureKey** | **string** | Service Descriptor Signature Key | [optional] 
**Authoritative** | **string** | If the root domain of the service described by the entry is on the same DNS domain or on a DNS subdomain thereof. | [optional] 
**Id** | **string** | Service descriptor identifier | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

