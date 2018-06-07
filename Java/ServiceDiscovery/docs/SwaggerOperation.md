
# SwaggerOperation

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tags** | **List&lt;String&gt;** | Gets or sets the tags. |  [optional]
**summary** | **String** | Gets or sets the summary of the operation. |  [optional]
**description** | **String** | Gets or sets the long description of the operation. |  [optional]
**externalDocs** | [**SwaggerExternalDocumentation**](SwaggerExternalDocumentation.md) | Gets or sets the external documentation. |  [optional]
**operationId** | **String** | Gets or sets the operation ID (unique name). |  [optional]
**schemes** | [**List&lt;SchemesEnum&gt;**](#List&lt;SchemesEnum&gt;) | Gets or sets the schemes. |  [optional]
**consumes** | **List&lt;String&gt;** | Gets or sets a list of MIME types the operation can consume. |  [optional]
**produces** | **List&lt;String&gt;** | Gets or sets a list of MIME types the operation can produce. |  [optional]
**parameters** | [**List&lt;SwaggerParameter&gt;**](SwaggerParameter.md) | Gets or sets the parameters. |  [optional]
**responses** | [**Map&lt;String, SwaggerResponse&gt;**](SwaggerResponse.md) | Gets or sets the HTTP Status Code/Response pairs. | 
**deprecated** | **Boolean** | Gets or sets a value indicating whether the operation is deprecated. |  [optional]
**security** | [**List&lt;Map&lt;String, List&lt;String&gt;&gt;&gt;**](Map.md) | Gets or sets a security description. |  [optional]


<a name="List<SchemesEnum>"></a>
## Enum: List&lt;SchemesEnum&gt;
Name | Value
---- | -----
UNDEFINED | &quot;undefined&quot;
HTTP | &quot;http&quot;
HTTPS | &quot;https&quot;
WS | &quot;ws&quot;
WSS | &quot;wss&quot;



