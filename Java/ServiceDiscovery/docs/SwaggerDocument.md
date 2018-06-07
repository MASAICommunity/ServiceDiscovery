
# SwaggerDocument

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**xGenerator** | **String** | Gets or sets the Swagger generator information. |  [optional]
**swagger** | **String** | Gets or sets the Swagger specification version being used. |  [optional]
**info** | [**SwaggerInfo**](SwaggerInfo.md) | Gets or sets the metadata about the API. |  [optional]
**host** | **String** | Gets or sets the host (name or ip) serving the API. |  [optional]
**basePath** | **String** | Gets or sets the base path on which the API is served, which is relative to the {NSwag.SwaggerDocument.Host}. |  [optional]
**schemes** | [**List&lt;SchemesEnum&gt;**](#List&lt;SchemesEnum&gt;) | Gets or sets the schemes. |  [optional]
**consumes** | **List&lt;String&gt;** | Gets or sets a list of MIME types the operation can consume. |  [optional]
**produces** | **List&lt;String&gt;** | Gets or sets a list of MIME types the operation can produce. |  [optional]
**paths** | [**Map&lt;String, SwaggerDocumentPaths&gt;**](SwaggerDocumentPaths.md) | Gets or sets the operations. |  [optional]
**definitions** | [**Map&lt;String, JsonSchema4&gt;**](JsonSchema4.md) | Gets or sets the types. |  [optional]
**parameters** | [**Map&lt;String, SwaggerParameter&gt;**](SwaggerParameter.md) | Gets or sets the parameters which can be used for all operations. |  [optional]
**responses** | [**Map&lt;String, SwaggerResponse&gt;**](SwaggerResponse.md) | Gets or sets the responses which can be used for all operations. |  [optional]
**securityDefinitions** | [**Map&lt;String, SwaggerSecurityScheme&gt;**](SwaggerSecurityScheme.md) | Gets or sets the security definitions. |  [optional]
**security** | [**List&lt;Map&lt;String, List&lt;String&gt;&gt;&gt;**](Map.md) | Gets or sets a security description. |  [optional]
**tags** | [**List&lt;SwaggerTag&gt;**](SwaggerTag.md) | Gets or sets the description. |  [optional]
**externalDocs** | [**SwaggerExternalDocumentation**](SwaggerExternalDocumentation.md) | Gets or sets the external documentation. |  [optional]


<a name="List<SchemesEnum>"></a>
## Enum: List&lt;SchemesEnum&gt;
Name | Value
---- | -----
UNDEFINED | &quot;undefined&quot;
HTTP | &quot;http&quot;
HTTPS | &quot;https&quot;
WS | &quot;ws&quot;
WSS | &quot;wss&quot;



