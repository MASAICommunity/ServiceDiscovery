# MASAIData

## Properties

|===
|Name | Type | Description | Notes

|**planConditions** | **NSString*** | Plan conditions of the service | [optional] 
|**swagger** | [**MASAISwaggerDocument***](MASAISwaggerDocument.md) | Swagger file information | [optional] 
|**properties** | link:MASAIProperties.html[**NSArray&lt;MASAIProperties&gt;***] | Properties service information | [optional] 
|**contact** | link:MASAIContact.html[**NSArray&lt;MASAIContact&gt;***] | Contact service information | [optional] 
|**maintainers** | link:MASAIMaintainers.html[**NSArray&lt;MASAIMaintainers&gt;***] | Maintainers service informatoin | [optional] 
|**tags** | **NSArray&lt;NSString*&gt;*** | Tags service information | [optional] 
|**integrationMode** | **NSString*** | Information related to how the service is integrated | [optional] 
|**levelOfService** | **NSArray&lt;NSString*&gt;*** | Level of service provided | [optional] 
|**name** | **NSString*** | Name of the service | [optional] 
|**_description** | **NSString*** | Description of the service | [optional] 
|**image** | **NSString*** | Image related of the service | [optional] 
|**baseURL** | **NSString*** | Base URL of the service | [optional] 
|**humanURL** | **NSString*** | URL of the human readable documentation | [optional] 
|**appName** | **NSString*** | App name of the service if the integration mode is \&quot;app\&quot;. E.g.: \&quot;Travel Concierge\&quot; | [optional] 
|**packageName** | **NSString*** | Package name of the service if the integration mode is \&quot;app\&quot;. E.g.: \&quot;com.serviceprovider.travelconcierge\&quot; | [optional] 
|**deeplinkURL** | **NSString*** | Base deeplink URL of the service to integrate directly with application. (This attribute will appear only if integration mode is \&quot;app\&quot;.) | [optional] 
|**planConditionsUrl** | **NSString*** | Plan conditions URL with human readable information | [optional] 
|**updatedAt** | **NSString*** | Timestamp of when service was updated | [optional] 
|**signatureKey** | **NSString*** | Service Descriptor Signature Key | [optional] 
|**authoritative** | **NSString*** | If the root domain of the service described by the entry is on the same DNS domain or on a DNS subdomain thereof. | [optional] 
|**_id** | **NSString*** | Service descriptor identifier | [optional] 
|===

link:../README.html#documentation-for-models[[Back to Model list]] link:../README.html#documentation-for-api-endpoints[[Back to API list]] link:../README.html[[Back to README]]


