# MASAISwaggerParameter

## Properties
|===
|Name | Type | Description | Notes

|**schema** | **NSString*** |  | [optional] 
|**_id** | **NSString*** |  | [optional] 
|**title** | **NSString*** |  | [optional] 
|**type** | **NSObject*** |  | [optional] 
|**discriminator** | **NSString*** |  | [optional] 
|**name** | **NSString*** | Gets or sets the name. | [optional] 
|**in** | **NSString*** | Gets or sets the kind of the parameter. | [optional] 
|**required** | **NSNumber*** | Gets or sets a value indicating whether the parameter is required (default: false). | [optional] 
|**allowEmptyValue** | **NSNumber*** | Gets or sets a value indicating whether passing empty-valued parameters is allowed (default: false). | [optional] 
|**schema** | link:MASAIJsonSchema4.html[**MASAIJsonSchema4***] | Gets or sets the schema which is only available when {NSwag.SwaggerParameter.Kind} &#x3D;&#x3D; body. | [optional] 
|**xNullable** | **NSNumber*** | Sets a value indicating whether the parameter can be null (use IsNullable() to get a parameter&#39;s nullability). | [optional] 
|**collectionFormat** | **NSString*** | Gets or sets the format of the array if type array is used. | [optional] 
|**_description** | **NSString*** |  | [optional] 
|**schemaReferencePath** | **NSString*** |  | [optional] 
|**format** | **NSString*** |  | [optional] 
|**_default** | **NSObject*** |  | [optional] 
|**multipleOf** | **NSNumber*** |  | [optional] 
|**maximum** | **NSNumber*** |  | [optional] 
|**exclusiveMaximum** | **NSNumber*** |  | [optional] 
|**minimum** | **NSNumber*** |  | [optional] 
|**exclusiveMinimum** | **NSNumber*** |  | [optional] 
|**maxLength** | **NSNumber*** |  | [optional] 
|**minLength** | **NSNumber*** |  | [optional] 
|**pattern** | **NSString*** |  | [optional] 
|**maxItems** | **NSNumber*** |  | [optional] 
|**minItems** | **NSNumber*** |  | [optional] 
|**uniqueItems** | **NSNumber*** |  | [optional] 
|**maxProperties** | **NSNumber*** |  | [optional] 
|**minProperties** | **NSNumber*** |  | [optional] 
|**xml** | link:MASAIJsonXmlObject.html[**MASAIJsonXmlObject***] |  | [optional] 
|**not** | link:MASAIJsonSchema4.html[**MASAIJsonSchema4***] |  | [optional] 
|**additionalItems** | **NSObject*** |  | [optional] 
|**additionalProperties** | **NSObject*** |  | [optional] 
|**items** | **NSObject*** |  | [optional] 
|**properties** | link:MASAIJsonSchema4.html[**NSDictionary&lt;MASAIJsonSchema4&gt;***] |  | [optional] 
|**patternProperties** | link:MASAIJsonSchema4.html[**NSDictionary&lt;MASAIJsonSchema4&gt;***] |  | [optional] 
|**definitions** | link:MASAIJsonSchema4.html[**NSDictionary&lt;MASAIJsonSchema4&gt;***] |  | [optional] 
|**xEnumNames** | **NSArray&lt;NSString*&gt;*** |  | [optional] 
|**_enum** | **NSArray&lt;NSObject*&gt;*** |  | [optional] 
|**allOf** | link:MASAIJsonSchema4.html[**NSArray&lt;MASAIJsonSchema4&gt;***] |  | [optional] 
|**anyOf** | link:MASAIJsonSchema4.html[**NSArray&lt;MASAIJsonSchema4&gt;***] |  | [optional] 
|**oneOf** | link:MASAIJsonSchema4.html[**NSArray&lt;MASAIJsonSchema4&gt;***] |  | [optional] 
|===

link:../README.html#documentation-for-models[[Back to Model list]] link:../README.html#documentation-for-api-endpoints[[Back to API list]] link:../README.html[[Back to README]]


