# SwaggerDocument

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**x_generator** | **string** | Gets or sets the Swagger generator information. | [optional] 
**swagger** | **string** | Gets or sets the Swagger specification version being used. | [optional] 
**info** | [**\Swagger\Client\Model\SwaggerInfo**](SwaggerInfo.md) | Gets or sets the metadata about the API. | [optional] 
**host** | **string** | Gets or sets the host (name or ip) serving the API. | [optional] 
**base_path** | **string** | Gets or sets the base path on which the API is served, which is relative to the {NSwag.SwaggerDocument.Host}. | [optional] 
**schemes** | **string[]** | Gets or sets the schemes. | [optional] 
**consumes** | **string[]** | Gets or sets a list of MIME types the operation can consume. | [optional] 
**produces** | **string[]** | Gets or sets a list of MIME types the operation can produce. | [optional] 
**paths** | [**map[string,\Swagger\Client\Model\SwaggerDocumentPaths]**](SwaggerDocumentPaths.md) | Gets or sets the operations. | [optional] 
**definitions** | [**map[string,\Swagger\Client\Model\JsonSchema4]**](JsonSchema4.md) | Gets or sets the types. | [optional] 
**parameters** | [**map[string,\Swagger\Client\Model\SwaggerParameter]**](SwaggerParameter.md) | Gets or sets the parameters which can be used for all operations. | [optional] 
**responses** | [**map[string,\Swagger\Client\Model\SwaggerResponse]**](SwaggerResponse.md) | Gets or sets the responses which can be used for all operations. | [optional] 
**security_definitions** | [**map[string,\Swagger\Client\Model\SwaggerSecurityScheme]**](SwaggerSecurityScheme.md) | Gets or sets the security definitions. | [optional] 
**security** | [**map[string,string[]][]**](map.md) | Gets or sets a security description. | [optional] 
**tags** | [**\Swagger\Client\Model\SwaggerTag[]**](SwaggerTag.md) | Gets or sets the description. | [optional] 
**external_docs** | [**\Swagger\Client\Model\SwaggerExternalDocumentation**](SwaggerExternalDocumentation.md) | Gets or sets the external documentation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


