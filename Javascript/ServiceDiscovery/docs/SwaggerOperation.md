# ServiceDiscovery.SwaggerOperation

## Properties
|===
|Name | Type | Description | Notes

|**tags** | **[String]** | Gets or sets the tags. | [optional] 
|**summary** | **String** | Gets or sets the summary of the operation. | [optional] 
|**description** | **String** | Gets or sets the long description of the operation. | [optional] 
|**externalDocs** | link:SwaggerExternalDocumentation.html[**SwaggerExternalDocumentation**] | Gets or sets the external documentation. | [optional] 
|**operationId** | **String** | Gets or sets the operation ID (unique name). | [optional] 
|**schemes** | **[String]** | Gets or sets the schemes. | [optional] 
|**consumes** | **[String]** | Gets or sets a list of MIME types the operation can consume. | [optional] 
|**produces** | **[String]** | Gets or sets a list of MIME types the operation can produce. | [optional] 
|**parameters** | link:SwaggerParameter.html[**[SwaggerParameter]**] | Gets or sets the parameters. | [optional] 
|**responses** | link:SwaggerResponse.html[**{String: SwaggerResponse}**] | Gets or sets the HTTP Status Code/Response pairs. | 
|**deprecated** | **Boolean** | Gets or sets a value indicating whether the operation is deprecated. | [optional] 
|**security** | **[{String: [String]}]** | Gets or sets a security description. | [optional] 
|===


<a name="[SchemesEnum]"></a>
## Enum: [SchemesEnum]


* `undefined` (value: `"undefined"`)

* `http` (value: `"http"`)

* `https` (value: `"https"`)

* `ws` (value: `"ws"`)

* `wss` (value: `"wss"`)




