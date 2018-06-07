# ServiceDiscovery.Data

## Properties
|===
|Name | Type | Description | Notes

|**planConditions** | **String** | Plan conditions of the service | [optional] 
|**swagger** | link:SwaggerDocument.html[**SwaggerDocument**] | Swagger file information | [optional] 
|**properties** | link:Properties.html[**[Properties]**] | Properties service information | [optional] 
|**contact** | link:Contact.html[**[Contact]**] | Contact service information | [optional] 
|**maintainers** | link:Maintainers.html[**[Maintainers]**] | Maintainers service informatoin | [optional] 
|**tags** | **[String]** | Tags service information | [optional] 
|**integrationMode** | **String** | Information related to how the service is integrated | [optional] 
|**levelOfService** | **[String]** | Level of service provided | [optional] 
|**name** | **String** | Name of the service | [optional] 
|**description** | **String** | Description of the service | [optional] 
|**image** | **String** | Image related of the service | [optional] 
|**baseURL** | **String** | Base URL of the service | [optional] 
|**humanURL** | **String** | URL of the human readable documentation | [optional] 
|**appName** | **String** | App name of the service if the integration mode is \&quot;app\&quot;. E.g.: \&quot;Travel Concierge\&quot; | [optional] 
|**packageName** | **String** | Package name of the service if the integration mode is \&quot;app\&quot;. E.g.: \&quot;com.serviceprovider.travelconcierge\&quot; | [optional] 
|**deeplinkURL** | **String** | Base deeplink URL of the service to integrate directly with application. (This attribute will appear only if integration mode is \&quot;app\&quot;.) | [optional] 
|**planConditionsUrl** | **String** | Plan conditions URL with human readable information | [optional] 
|**updatedAt** | **String** | Timestamp of when service was updated | [optional] 
|**signatureKey** | **String** | Service Descriptor Signature Key | [optional] 
|**authoritative** | **String** | If the root domain of the service described by the entry is on the same DNS domain or on a DNS subdomain thereof. | [optional] 
|**id** | **String** | Service descriptor identifier | [optional] 
|===


<a name="PlanConditionsEnum"></a>
## Enum: PlanConditionsEnum


* `free` (value: `"free"`)

* `paid` (value: `"paid"`)




<a name="[LevelOfServiceEnum]"></a>
## Enum: [LevelOfServiceEnum]


* `VIP` (value: `"VIP"`)

* `Economy` (value: `"Economy"`)

* `Regular` (value: `"Regular"`)

* `Luxury` (value: `"Luxury"`)

* `Executive` (value: `"Executive"`)

* `Exclusive` (value: `"Exclusive"`)

* `Deluxe` (value: `"Deluxe"`)




