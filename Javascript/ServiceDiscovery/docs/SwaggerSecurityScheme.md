# ServiceDiscovery.SwaggerSecurityScheme

## Properties
|===
|Name | Type | Description | Notes

|**type** | **String** | Gets or sets the type of the security scheme. | 
|**description** | **String** | Gets or sets the short description for security scheme. | [optional] 
|**name** | **String** | Gets or sets the name of the header or query parameter to be used to transmit the API key. | [optional] 
|**_in** | **String** | Gets or sets the type of the API key. | [optional] 
|**flow** | **String** | Gets or sets the used by the OAuth2 security scheme. | [optional] 
|**authorizationUrl** | **String** | Gets or sets the authorization URL to be used for this flow. | [optional] 
|**tokenUrl** | **String** | Gets or sets the token URL to be used for this flow. . | [optional] 
|**scopes** | **{String: String}** | Gets the available scopes for the OAuth2 security scheme. | [optional] 
|===


<a name="TypeEnum"></a>
## Enum: TypeEnum


* `Undefined` (value: `"Undefined"`)

* `basic` (value: `"basic"`)

* `apiKey` (value: `"apiKey"`)

* `oauth2` (value: `"oauth2"`)




<a name="InEnum"></a>
## Enum: InEnum


* `Undefined` (value: `"Undefined"`)

* `query` (value: `"query"`)

* `header` (value: `"header"`)




<a name="FlowEnum"></a>
## Enum: FlowEnum


* `undefined` (value: `"undefined"`)

* `implicit` (value: `"implicit"`)

* `password` (value: `"password"`)

* `application` (value: `"application"`)

* `accessCode` (value: `"accessCode"`)




