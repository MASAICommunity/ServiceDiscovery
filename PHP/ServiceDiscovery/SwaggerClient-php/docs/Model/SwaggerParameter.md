# SwaggerParameter

## Properties
|===
|Name | Type | Description | Notes

|**schema** | **string** |  | [optional] 
|**id** | **string** |  | [optional] 
|**title** | **string** |  | [optional] 
|**type** | **object** |  | [optional] 
|**discriminator** | **string** |  | [optional] 
|**name** | **string** | Gets or sets the name. | [optional] 
|**in** | **string** | Gets or sets the kind of the parameter. | [optional] 
|**required** | **bool** | Gets or sets a value indicating whether the parameter is required (default: false). | [optional] 
|**allow_empty_value** | **bool** | Gets or sets a value indicating whether passing empty-valued parameters is allowed (default: false). | [optional] 
|**schema** | link:JsonSchema4.html[**\Swagger\Client\Model\JsonSchema4**] | Gets or sets the schema which is only available when {NSwag.SwaggerParameter.Kind} &#x3D;&#x3D; body. | [optional] 
|**x_nullable** | **bool** | Sets a value indicating whether the parameter can be null (use IsNullable() to get a parameter&#39;s nullability). | [optional] 
|**collection_format** | **string** | Gets or sets the format of the array if type array is used. | [optional] 
|**description** | **string** |  | [optional] 
|**schema_reference_path** | **string** |  | [optional] 
|**format** | **string** |  | [optional] 
|**default** | **object** |  | [optional] 
|**multiple_of** | **double** |  | [optional] 
|**maximum** | **double** |  | [optional] 
|**exclusive_maximum** | **bool** |  | [optional] 
|**minimum** | **double** |  | [optional] 
|**exclusive_minimum** | **bool** |  | [optional] 
|**max_length** | **int** |  | [optional] 
|**min_length** | **int** |  | [optional] 
|**pattern** | **string** |  | [optional] 
|**max_items** | **int** |  | [optional] 
|**min_items** | **int** |  | [optional] 
|**unique_items** | **bool** |  | [optional] 
|**max_properties** | **int** |  | [optional] 
|**min_properties** | **int** |  | [optional] 
|**xml** | link:JsonXmlObject.html[**\Swagger\Client\Model\JsonXmlObject**] |  | [optional] 
|**not** | link:JsonSchema4.html[**\Swagger\Client\Model\JsonSchema4**] |  | [optional] 
|**additional_items** | **object** |  | [optional] 
|**additional_properties** | **object** |  | [optional] 
|**items** | **object** |  | [optional] 
|**properties** | link:JsonSchema4.html[**map[string,\Swagger\Client\Model\JsonSchema4]**] |  | [optional] 
|**pattern_properties** | link:JsonSchema4.html[**map[string,\Swagger\Client\Model\JsonSchema4]**] |  | [optional] 
|**definitions** | link:JsonSchema4.html[**map[string,\Swagger\Client\Model\JsonSchema4]**] |  | [optional] 
|**x_enum_names** | **string[]** |  | [optional] 
|**enum** | **object[]** |  | [optional] 
|**all_of** | link:JsonSchema4.html[**\Swagger\Client\Model\JsonSchema4[]**] |  | [optional] 
|**any_of** | link:JsonSchema4.html[**\Swagger\Client\Model\JsonSchema4[]**] |  | [optional] 
|**one_of** | link:JsonSchema4.html[**\Swagger\Client\Model\JsonSchema4[]**] |  | [optional] 
|===

link:../../README.html#documentation-for-models[[Back to Model list]] link:../../README.html#documentation-for-api-endpoints[[Back to API list]] link:../../README.html[[Back to README]]


