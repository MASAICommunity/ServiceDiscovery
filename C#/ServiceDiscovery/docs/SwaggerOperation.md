# ServiceDiscovery.Model.SwaggerOperation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tags** | **List&lt;string&gt;** | Gets or sets the tags. | [optional] 
**Summary** | **string** | Gets or sets the summary of the operation. | [optional] 
**Description** | **string** | Gets or sets the long description of the operation. | [optional] 
**ExternalDocs** | [**SwaggerExternalDocumentation**](SwaggerExternalDocumentation.md) | Gets or sets the external documentation. | [optional] 
**OperationId** | **string** | Gets or sets the operation ID (unique name). | [optional] 
**Schemes** | **List&lt;string&gt;** | Gets or sets the schemes. | [optional] 
**Consumes** | **List&lt;string&gt;** | Gets or sets a list of MIME types the operation can consume. | [optional] 
**Produces** | **List&lt;string&gt;** | Gets or sets a list of MIME types the operation can produce. | [optional] 
**Parameters** | [**List&lt;SwaggerParameter&gt;**](SwaggerParameter.md) | Gets or sets the parameters. | [optional] 
**Responses** | [**Dictionary&lt;string, SwaggerResponse&gt;**](SwaggerResponse.md) | Gets or sets the HTTP Status Code/Response pairs. | 
**Deprecated** | **bool?** | Gets or sets a value indicating whether the operation is deprecated. | [optional] 
**Security** | **List&lt;Dictionary&lt;string, List&lt;string&gt;&gt;&gt;** | Gets or sets a security description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

