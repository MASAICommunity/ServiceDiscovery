# ServiceDiscovery.SwaggerParameter

## Properties
|===
|Name | Type | Description | Notes

|**schema** | **String** |  | [optional] 
|**id** | **String** |  | [optional] 
|**title** | **String** |  | [optional] 
|**type** | **Object** |  | [optional] 
|**discriminator** | **String** |  | [optional] 
|**name** | **String** | Gets or sets the name. | [optional] 
|**_in** | **String** | Gets or sets the kind of the parameter. | [optional] 
|**required** | **Boolean** | Gets or sets a value indicating whether the parameter is required (default: false). | [optional] 
|**allowEmptyValue** | **Boolean** | Gets or sets a value indicating whether passing empty-valued parameters is allowed (default: false). | [optional] 
|**schema** | link:JsonSchema4.html[**JsonSchema4**] | Gets or sets the schema which is only available when {NSwag.SwaggerParameter.Kind} &#x3D;&#x3D; body. | [optional] 
|**xNullable** | **Boolean** | Sets a value indicating whether the parameter can be null (use IsNullable() to get a parameter&#39;s nullability). | [optional] 
|**collectionFormat** | **String** | Gets or sets the format of the array if type array is used. | [optional] 
|**description** | **String** |  | [optional] 
|**schemaReferencePath** | **String** |  | [optional] 
|**format** | **String** |  | [optional] 
|**_default** | **Object** |  | [optional] 
|**multipleOf** | **Number** |  | [optional] 
|**maximum** | **Number** |  | [optional] 
|**exclusiveMaximum** | **Boolean** |  | [optional] 
|**minimum** | **Number** |  | [optional] 
|**exclusiveMinimum** | **Boolean** |  | [optional] 
|**maxLength** | **Number** |  | [optional] 
|**minLength** | **Number** |  | [optional] 
|**pattern** | **String** |  | [optional] 
|**maxItems** | **Number** |  | [optional] 
|**minItems** | **Number** |  | [optional] 
|**uniqueItems** | **Boolean** |  | [optional] 
|**maxProperties** | **Number** |  | [optional] 
|**minProperties** | **Number** |  | [optional] 
|**xml** | link:JsonXmlObject.html[**JsonXmlObject**] |  | [optional] 
|**not** | link:JsonSchema4.html[**JsonSchema4**] |  | [optional] 
|**additionalItems** | **Object** |  | [optional] 
|**additionalProperties** | **Object** |  | [optional] 
|**items** | **Object** |  | [optional] 
|**properties** | link:JsonSchema4.html[**{String: JsonSchema4}**] |  | [optional] 
|**patternProperties** | link:JsonSchema4.html[**{String: JsonSchema4}**] |  | [optional] 
|**definitions** | link:JsonSchema4.html[**{String: JsonSchema4}**] |  | [optional] 
|**xEnumNames** | **[String]** |  | [optional] 
|**_enum** | **[Object]** |  | [optional] 
|**allOf** | link:JsonSchema4.html[**[JsonSchema4]**] |  | [optional] 
|**anyOf** | link:JsonSchema4.html[**[JsonSchema4]**] |  | [optional] 
|**oneOf** | link:JsonSchema4.html[**[JsonSchema4]**] |  | [optional] 
|===


<a name="InEnum"></a>
## Enum: InEnum


* `undefined` (value: `"undefined"`)

* `body` (value: `"body"`)

* `query` (value: `"query"`)

* `path` (value: `"path"`)

* `header` (value: `"header"`)

* `formData` (value: `"formData"`)

* `modelbinding` (value: `"modelbinding"`)




<a name="CollectionFormatEnum"></a>
## Enum: CollectionFormatEnum


* `undefined` (value: `"undefined"`)

* `csv` (value: `"csv"`)

* `ssv` (value: `"ssv"`)

* `tsv` (value: `"tsv"`)

* `pipes` (value: `"pipes"`)

* `multi` (value: `"multi"`)




