# Data

## Properties
|===
|Name | Type | Description | Notes

|**plan_conditions** | **string** | Plan conditions of the service | [optional] 
|**swagger** | link:SwaggerDocument.html[**\Swagger\Client\Model\SwaggerDocument**] | Swagger file information | [optional] 
|**properties** | link:Properties.html[**\Swagger\Client\Model\Properties[]**] | Properties service information | [optional] 
|**contact** | link:Contact.html[**\Swagger\Client\Model\Contact[]**] | Contact service information | [optional] 
|**maintainers** | link:Maintainers.html[**\Swagger\Client\Model\Maintainers[]**] | Maintainers service informatoin | [optional] 
|**tags** | **string[]** | Tags service information | [optional] 
|**integration_mode** | **string** | Information related to how the service is integrated | [optional] 
|**level_of_service** | **string[]** | Level of service provided | [optional] 
|**name** | **string** | Name of the service | [optional] 
|**description** | **string** | Description of the service | [optional] 
|**image** | **string** | Image related of the service | [optional] 
|**base_url** | **string** | Base URL of the service | [optional] 
|**human_url** | **string** | URL of the human readable documentation | [optional] 
|**app_name** | **string** | App name of the service if the integration mode is \&quot;app\&quot;. E.g.: \&quot;Travel Concierge\&quot; | [optional] 
|**package_name** | **string** | Package name of the service if the integration mode is \&quot;app\&quot;. E.g.: \&quot;com.serviceprovider.travelconcierge\&quot; | [optional] 
|**deeplink_url** | **string** | Base deeplink URL of the service to integrate directly with application. (This attribute will appear only if integration mode is \&quot;app\&quot;.) | [optional] 
|**plan_conditions_url** | **string** | Plan conditions URL with human readable information | [optional] 
|**updated_at** | **string** | Timestamp of when service was updated | [optional] 
|**signature_key** | **string** | Service Descriptor Signature Key | [optional] 
|**authoritative** | **string** | If the root domain of the service described by the entry is on the same DNS domain or on a DNS subdomain thereof. | [optional] 
|**id** | **string** | Service descriptor identifier | [optional] 
|===

link:../../README.html#documentation-for-models[[Back to Model list]] link:../../README.html#documentation-for-api-endpoints[[Back to API list]] link:../../README.html[[Back to README]]