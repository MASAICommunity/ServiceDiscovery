# ServiceDiscovery.Model.SwaggerDocument
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**XGenerator** | **string** | Gets or sets the Swagger generator information. | [optional] 
**Swagger** | **string** | Gets or sets the Swagger specification version being used. | [optional] 
**Info** | [**SwaggerInfo**](SwaggerInfo.md) | Gets or sets the metadata about the API. | [optional] 
**Host** | **string** | Gets or sets the host (name or ip) serving the API. | [optional] 
**BasePath** | **string** | Gets or sets the base path on which the API is served, which is relative to the {NSwag.SwaggerDocument.Host}. | [optional] 
**Schemes** | **List&lt;string&gt;** | Gets or sets the schemes. | [optional] 
**Consumes** | **List&lt;string&gt;** | Gets or sets a list of MIME types the operation can consume. | [optional] 
**Produces** | **List&lt;string&gt;** | Gets or sets a list of MIME types the operation can produce. | [optional] 
**Paths** | [**Dictionary&lt;string, SwaggerDocumentPaths&gt;**](SwaggerDocumentPaths.md) | Gets or sets the operations. | [optional] 
**Definitions** | [**Dictionary&lt;string, JsonSchema4&gt;**](JsonSchema4.md) | Gets or sets the types. | [optional] 
**Parameters** | [**Dictionary&lt;string, SwaggerParameter&gt;**](SwaggerParameter.md) | Gets or sets the parameters which can be used for all operations. | [optional] 
**Responses** | [**Dictionary&lt;string, SwaggerResponse&gt;**](SwaggerResponse.md) | Gets or sets the responses which can be used for all operations. | [optional] 
**SecurityDefinitions** | [**Dictionary&lt;string, SwaggerSecurityScheme&gt;**](SwaggerSecurityScheme.md) | Gets or sets the security definitions. | [optional] 
**Security** | **List&lt;Dictionary&lt;string, List&lt;string&gt;&gt;&gt;** | Gets or sets a security description. | [optional] 
**Tags** | [**List&lt;SwaggerTag&gt;**](SwaggerTag.md) | Gets or sets the description. | [optional] 
**ExternalDocs** | [**SwaggerExternalDocumentation**](SwaggerExternalDocumentation.md) | Gets or sets the external documentation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

