# SwaggerOperation

## Properties
|===
|Name | Type | Description | Notes

|**tags** | **string[]** | Gets or sets the tags. | [optional] 
|**summary** | **string** | Gets or sets the summary of the operation. | [optional] 
|**description** | **string** | Gets or sets the long description of the operation. | [optional] 
|**external_docs** | link:SwaggerExternalDocumentation.html[**\Swagger\Client\Model\SwaggerExternalDocumentation**] | Gets or sets the external documentation. | [optional] 
|**operation_id** | **string** | Gets or sets the operation ID (unique name). | [optional] 
|**schemes** | **string[]** | Gets or sets the schemes. | [optional] 
|**consumes** | **string[]** | Gets or sets a list of MIME types the operation can consume. | [optional] 
|**produces** | **string[]** | Gets or sets a list of MIME types the operation can produce. | [optional] 
|**parameters** | link:SwaggerParameter.html[**\Swagger\Client\Model\SwaggerParameter[]**] | Gets or sets the parameters. | [optional] 
|**responses** | link:SwaggerResponse.html[**map[string,\Swagger\Client\Model\SwaggerResponse]**] | Gets or sets the HTTP Status Code/Response pairs. | 
|**deprecated** | **bool** | Gets or sets a value indicating whether the operation is deprecated. | [optional] 
|**security** | link:map.html[**map[string,string[]][]**] | Gets or sets a security description. | [optional] 
|===

link:../../README.html#documentation-for-models[[Back to Model list]] link:../../README.html#documentation-for-api-endpoints[[Back to API list]] link:../../README.html[[Back to README]]


