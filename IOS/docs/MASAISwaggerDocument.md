# MASAISwaggerDocument

## Properties
|===
|Name | Type | Description | Notes

|**xGenerator** | **NSString*** | Gets or sets the Swagger generator information. | [optional] 
|**swagger** | **NSString*** | Gets or sets the Swagger specification version being used. | [optional] 
|**info** | link:MASAISwaggerInfo.html[**MASAISwaggerInfo***] | Gets or sets the metadata about the API. | [optional] 
|**host** | **NSString*** | Gets or sets the host (name or ip) serving the API. | [optional] 
|**basePath** | **NSString*** | Gets or sets the base path on which the API is served, which is relative to the {NSwag.SwaggerDocument.Host}. | [optional] 
|**schemes** | **NSArray&lt;NSString*&gt;*** | Gets or sets the schemes. | [optional] 
|**consumes** | **NSArray&lt;NSString*&gt;*** | Gets or sets a list of MIME types the operation can consume. | [optional] 
|**produces** | **NSArray&lt;NSString*&gt;*** | Gets or sets a list of MIME types the operation can produce. | [optional] 
|**paths** | link:MASAISwaggerDocumentPaths.html[**NSDictionary&lt;MASAISwaggerDocumentPaths&gt;***] | Gets or sets the operations. | [optional] 
|**definitions** | link:MASAIJsonSchema4.html[**NSDictionary&lt;MASAIJsonSchema4&gt;***] | Gets or sets the types. | [optional] 
|**parameters** | link:MASAISwaggerParameter.html[**NSDictionary&lt;MASAISwaggerParameter&gt;***] | Gets or sets the parameters which can be used for all operations. | [optional] 
|**responses** | link:MASAISwaggerResponse.html[**NSDictionary&lt;MASAISwaggerResponse&gt;***] | Gets or sets the responses which can be used for all operations. | [optional] 
|**securityDefinitions** | link:MASAISwaggerSecurityScheme.html[**NSDictionary&lt;MASAISwaggerSecurityScheme&gt;***] | Gets or sets the security definitions. | [optional] 
|**security** | link:NSDictionary.html[**NSArray&lt;NSDictionary&lt;NSString*, NSArray&lt;NSString*&gt;*&gt;*&gt;***] | Gets or sets a security description. | [optional] 
|**tags** | link:MASAISwaggerTag.html[**NSArray&lt;MASAISwaggerTag&gt;***] | Gets or sets the description. | [optional] 
|**externalDocs** | link:MASAISwaggerExternalDocumentation.html[**MASAISwaggerExternalDocumentation***] | Gets or sets the external documentation. | [optional] 
|===

link:../README.html#documentation-for-models[[Back to Model list]] link:../README.html#documentation-for-api-endpoints[[Back to API list]] link:../README.html[[Back to README]]


