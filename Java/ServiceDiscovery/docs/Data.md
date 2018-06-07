
# Data

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**planConditions** | [**PlanConditionsEnum**](#PlanConditionsEnum) | Plan conditions of the service |  [optional]
**swagger** | [**SwaggerDocument**](SwaggerDocument.md) | Swagger file information |  [optional]
**properties** | [**List&lt;Properties&gt;**](Properties.md) | Properties service information |  [optional]
**contact** | [**List&lt;Contact&gt;**](Contact.md) | Contact service information |  [optional]
**maintainers** | [**List&lt;Maintainers&gt;**](Maintainers.md) | Maintainers service informatoin |  [optional]
**tags** | **List&lt;String&gt;** | Tags service information |  [optional]
**integrationMode** | **String** | Information related to how the service is integrated |  [optional]
**levelOfService** | [**List&lt;LevelOfServiceEnum&gt;**](#List&lt;LevelOfServiceEnum&gt;) | Level of service provided |  [optional]
**name** | **String** | Name of the service |  [optional]
**description** | **String** | Description of the service |  [optional]
**image** | **String** | Image related of the service |  [optional]
**baseURL** | **String** | Base URL of the service |  [optional]
**humanURL** | **String** | URL of the human readable documentation |  [optional]
**appName** | **String** | App name of the service if the integration mode is \&quot;app\&quot;. E.g.: \&quot;Travel Concierge\&quot; |  [optional]
**packageName** | **String** | Package name of the service if the integration mode is \&quot;app\&quot;. E.g.: \&quot;com.serviceprovider.travelconcierge\&quot; |  [optional]
**deeplinkURL** | **String** | Base deeplink URL of the service to integrate directly with application. (This attribute will appear only if integration mode is \&quot;app\&quot;.) |  [optional]
**planConditionsUrl** | **String** | Plan conditions URL with human readable information |  [optional]
**updatedAt** | **String** | Timestamp of when service was updated |  [optional]
**signatureKey** | **String** | Service Descriptor Signature Key |  [optional]
**authoritative** | **String** | If the root domain of the service described by the entry is on the same DNS domain or on a DNS subdomain thereof. |  [optional]
**id** | **String** | Service descriptor identifier |  [optional]


<a name="PlanConditionsEnum"></a>
## Enum: PlanConditionsEnum
Name | Value
---- | -----
FREE | &quot;free&quot;
PAID | &quot;paid&quot;


<a name="List<LevelOfServiceEnum>"></a>
## Enum: List&lt;LevelOfServiceEnum&gt;
Name | Value
---- | -----
VIP | &quot;VIP&quot;
ECONOMY | &quot;Economy&quot;
REGULAR | &quot;Regular&quot;
LUXURY | &quot;Luxury&quot;
EXECUTIVE | &quot;Executive&quot;
EXCLUSIVE | &quot;Exclusive&quot;
DELUXE | &quot;Deluxe&quot;



