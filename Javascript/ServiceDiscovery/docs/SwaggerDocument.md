# ServiceDiscovery.SwaggerDocument

## Properties
|===
|Name | Type | Description | Notes

|**xGenerator** | **String** | Gets or sets the Swagger generator information. | [optional] 
|**swagger** | **String** | Gets or sets the Swagger specification version being used. | [optional] 
|**info** | link:SwaggerInfo.html[**SwaggerInfo**] | Gets or sets the metadata about the API. | [optional] 
|**host** | **String** | Gets or sets the host (name or ip) serving the API. | [optional] 
|**basePath** | **String** | Gets or sets the base path on which the API is served, which is relative to the {NSwag.SwaggerDocument.Host}. | [optional] 
|**schemes** | **[String]** | Gets or sets the schemes. | [optional] 
|**consumes** | **[String]** | Gets or sets a list of MIME types the operation can consume. | [optional] 
|**produces** | **[String]** | Gets or sets a list of MIME types the operation can produce. | [optional] 
|**paths** | link:SwaggerDocumentPaths.html[**{String: SwaggerDocumentPaths}**] | Gets or sets the operations. | [optional] 
|**definitions** | link:JsonSchema4.html[**{String: JsonSchema4}**] | Gets or sets the types. | [optional] 
|**parameters** | link:SwaggerParameter.html[**{String: SwaggerParameter}**] | Gets or sets the parameters which can be used for all operations. | [optional] 
|**responses** | link:SwaggerResponse.html[**{String: SwaggerResponse}**] | Gets or sets the responses which can be used for all operations. | [optional] 
|**securityDefinitions** | link:SwaggerSecurityScheme.html[**{String: SwaggerSecurityScheme}**] | Gets or sets the security definitions. | [optional] 
|**security** | **[{String: [String]}]** | Gets or sets a security description. | [optional] 
|**tags** | link:SwaggerTag.html[**[SwaggerTag]**] | Gets or sets the description. | [optional] 
|**externalDocs** | link:SwaggerExternalDocumentation.html[**SwaggerExternalDocumentation**] | Gets or sets the external documentation. | [optional] 
|===


<a name="[SchemesEnum]"></a>
## Enum: [SchemesEnum]


* `undefined` (value: `"undefined"`)

* `http` (value: `"http"`)

* `https` (value: `"https"`)

* `ws` (value: `"ws"`)

* `wss` (value: `"wss"`)




