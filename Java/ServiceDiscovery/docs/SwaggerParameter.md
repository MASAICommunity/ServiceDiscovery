
# SwaggerParameter

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**schema** | **String** |  |  [optional]
**id** | **String** |  |  [optional]
**title** | **String** |  |  [optional]
**type** | **Object** |  |  [optional]
**discriminator** | **String** |  |  [optional]
**name** | **String** | Gets or sets the name. |  [optional]
**in** | [**InEnum**](#InEnum) | Gets or sets the kind of the parameter. |  [optional]
**required** | **Boolean** | Gets or sets a value indicating whether the parameter is required (default: false). |  [optional]
**allowEmptyValue** | **Boolean** | Gets or sets a value indicating whether passing empty-valued parameters is allowed (default: false). |  [optional]
**schema** | [**JsonSchema4**](JsonSchema4.md) | Gets or sets the schema which is only available when {NSwag.SwaggerParameter.Kind} &#x3D;&#x3D; body. |  [optional]
**xNullable** | **Boolean** | Sets a value indicating whether the parameter can be null (use IsNullable() to get a parameter&#39;s nullability). |  [optional]
**collectionFormat** | [**CollectionFormatEnum**](#CollectionFormatEnum) | Gets or sets the format of the array if type array is used. |  [optional]
**description** | **String** |  |  [optional]
**schemaReferencePath** | **String** |  |  [optional]
**format** | **String** |  |  [optional]
**_default** | **Object** |  |  [optional]
**multipleOf** | **Double** |  |  [optional]
**maximum** | **Double** |  |  [optional]
**exclusiveMaximum** | **Boolean** |  |  [optional]
**minimum** | **Double** |  |  [optional]
**exclusiveMinimum** | **Boolean** |  |  [optional]
**maxLength** | **Integer** |  |  [optional]
**minLength** | **Integer** |  |  [optional]
**pattern** | **String** |  |  [optional]
**maxItems** | **Integer** |  |  [optional]
**minItems** | **Integer** |  |  [optional]
**uniqueItems** | **Boolean** |  |  [optional]
**maxProperties** | **Integer** |  |  [optional]
**minProperties** | **Integer** |  |  [optional]
**xml** | [**JsonXmlObject**](JsonXmlObject.md) |  |  [optional]
**not** | [**JsonSchema4**](JsonSchema4.md) |  |  [optional]
**additionalItems** | **Object** |  |  [optional]
**additionalProperties** | **Object** |  |  [optional]
**items** | **Object** |  |  [optional]
**properties** | [**Map&lt;String, JsonSchema4&gt;**](JsonSchema4.md) |  |  [optional]
**patternProperties** | [**Map&lt;String, JsonSchema4&gt;**](JsonSchema4.md) |  |  [optional]
**definitions** | [**Map&lt;String, JsonSchema4&gt;**](JsonSchema4.md) |  |  [optional]
**xEnumNames** | **List&lt;String&gt;** |  |  [optional]
**_enum** | **List&lt;Object&gt;** |  |  [optional]
**allOf** | [**List&lt;JsonSchema4&gt;**](JsonSchema4.md) |  |  [optional]
**anyOf** | [**List&lt;JsonSchema4&gt;**](JsonSchema4.md) |  |  [optional]
**oneOf** | [**List&lt;JsonSchema4&gt;**](JsonSchema4.md) |  |  [optional]


<a name="InEnum"></a>
## Enum: InEnum
Name | Value
---- | -----
UNDEFINED | &quot;undefined&quot;
BODY | &quot;body&quot;
QUERY | &quot;query&quot;
PATH | &quot;path&quot;
HEADER | &quot;header&quot;
FORMDATA | &quot;formData&quot;
MODELBINDING | &quot;modelbinding&quot;


<a name="CollectionFormatEnum"></a>
## Enum: CollectionFormatEnum
Name | Value
---- | -----
UNDEFINED | &quot;undefined&quot;
CSV | &quot;csv&quot;
SSV | &quot;ssv&quot;
TSV | &quot;tsv&quot;
PIPES | &quot;pipes&quot;
MULTI | &quot;multi&quot;



