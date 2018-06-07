
# SwaggerSecurityScheme

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**type** | [**TypeEnum**](#TypeEnum) | Gets or sets the type of the security scheme. | 
**description** | **String** | Gets or sets the short description for security scheme. |  [optional]
**name** | **String** | Gets or sets the name of the header or query parameter to be used to transmit the API key. |  [optional]
**in** | [**InEnum**](#InEnum) | Gets or sets the type of the API key. |  [optional]
**flow** | [**FlowEnum**](#FlowEnum) | Gets or sets the used by the OAuth2 security scheme. |  [optional]
**authorizationUrl** | **String** | Gets or sets the authorization URL to be used for this flow. |  [optional]
**tokenUrl** | **String** | Gets or sets the token URL to be used for this flow. . |  [optional]
**scopes** | **Map&lt;String, String&gt;** | Gets the available scopes for the OAuth2 security scheme. |  [optional]


<a name="TypeEnum"></a>
## Enum: TypeEnum
Name | Value
---- | -----
UNDEFINED | &quot;Undefined&quot;
BASIC | &quot;basic&quot;
APIKEY | &quot;apiKey&quot;
OAUTH2 | &quot;oauth2&quot;


<a name="InEnum"></a>
## Enum: InEnum
Name | Value
---- | -----
UNDEFINED | &quot;Undefined&quot;
QUERY | &quot;query&quot;
HEADER | &quot;header&quot;


<a name="FlowEnum"></a>
## Enum: FlowEnum
Name | Value
---- | -----
UNDEFINED | &quot;undefined&quot;
IMPLICIT | &quot;implicit&quot;
PASSWORD | &quot;password&quot;
APPLICATION | &quot;application&quot;
ACCESSCODE | &quot;accessCode&quot;



