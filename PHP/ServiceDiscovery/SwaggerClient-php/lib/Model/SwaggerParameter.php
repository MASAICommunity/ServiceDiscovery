<?php
/**
 * SwaggerParameter
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   http://github.com/swagger-api/swagger-codegen
 * @license  http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * MASAI Service Discovery API
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace Swagger\Client\Model;

use \ArrayAccess;

/**
 * SwaggerParameter Class Doc Comment
 *
 * @category    Class
 * @description Describes an operation parameter.
 * @package     Swagger\Client
 * @author      http://github.com/swagger-api/swagger-codegen
 * @license     http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class SwaggerParameter implements ArrayAccess
{
    /**
      * The original name of the model.
      * @var string
      */
    protected static $swaggerModelName = 'SwaggerParameter';

    /**
      * Array of property to type mappings. Used for (de)serialization
      * @var string[]
      */
    protected static $swaggerTypes = array(
        'schema' => 'string',
        'id' => 'string',
        'title' => 'string',
        'type' => 'object',
        'discriminator' => 'string',
        'name' => 'string',
        'in' => 'string',
        'required' => 'bool',
        'allow_empty_value' => 'bool',
        'schema' => '\Swagger\Client\Model\JsonSchema4',
        'x_nullable' => 'bool',
        'collection_format' => 'string',
        'description' => 'string',
        'schema_reference_path' => 'string',
        'format' => 'string',
        'default' => 'object',
        'multiple_of' => 'double',
        'maximum' => 'double',
        'exclusive_maximum' => 'bool',
        'minimum' => 'double',
        'exclusive_minimum' => 'bool',
        'max_length' => 'int',
        'min_length' => 'int',
        'pattern' => 'string',
        'max_items' => 'int',
        'min_items' => 'int',
        'unique_items' => 'bool',
        'max_properties' => 'int',
        'min_properties' => 'int',
        'xml' => '\Swagger\Client\Model\JsonXmlObject',
        'not' => '\Swagger\Client\Model\JsonSchema4',
        'additional_items' => 'object',
        'additional_properties' => 'object',
        'items' => 'object',
        'properties' => 'map[string,\Swagger\Client\Model\JsonSchema4]',
        'pattern_properties' => 'map[string,\Swagger\Client\Model\JsonSchema4]',
        'definitions' => 'map[string,\Swagger\Client\Model\JsonSchema4]',
        'x_enum_names' => 'string[]',
        'enum' => 'object[]',
        'all_of' => '\Swagger\Client\Model\JsonSchema4[]',
        'any_of' => '\Swagger\Client\Model\JsonSchema4[]',
        'one_of' => '\Swagger\Client\Model\JsonSchema4[]'
    );

    public static function swaggerTypes()
    {
        return self::$swaggerTypes;
    }

    /**
     * Array of attributes where the key is the local name, and the value is the original name
     * @var string[]
     */
    protected static $attributeMap = array(
        'schema' => '$schema',
        'id' => 'id',
        'title' => 'title',
        'type' => 'type',
        'discriminator' => 'discriminator',
        'name' => 'name',
        'in' => 'in',
        'required' => 'required',
        'allow_empty_value' => 'allowEmptyValue',
        'schema' => 'schema',
        'x_nullable' => 'x-nullable',
        'collection_format' => 'collectionFormat',
        'description' => 'description',
        'schema_reference_path' => 'schemaReferencePath',
        'format' => 'format',
        'default' => 'default',
        'multiple_of' => 'multipleOf',
        'maximum' => 'maximum',
        'exclusive_maximum' => 'exclusiveMaximum',
        'minimum' => 'minimum',
        'exclusive_minimum' => 'exclusiveMinimum',
        'max_length' => 'maxLength',
        'min_length' => 'minLength',
        'pattern' => 'pattern',
        'max_items' => 'maxItems',
        'min_items' => 'minItems',
        'unique_items' => 'uniqueItems',
        'max_properties' => 'maxProperties',
        'min_properties' => 'minProperties',
        'xml' => 'xml',
        'not' => 'not',
        'additional_items' => 'additionalItems',
        'additional_properties' => 'additionalProperties',
        'items' => 'items',
        'properties' => 'properties',
        'pattern_properties' => 'patternProperties',
        'definitions' => 'definitions',
        'x_enum_names' => 'x-enumNames',
        'enum' => 'enum',
        'all_of' => 'allOf',
        'any_of' => 'anyOf',
        'one_of' => 'oneOf'
    );

    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     * @var string[]
     */
    protected static $setters = array(
        'schema' => 'setSchema',
        'id' => 'setId',
        'title' => 'setTitle',
        'type' => 'setType',
        'discriminator' => 'setDiscriminator',
        'name' => 'setName',
        'in' => 'setIn',
        'required' => 'setRequired',
        'allow_empty_value' => 'setAllowEmptyValue',
        'schema' => 'setSchema',
        'x_nullable' => 'setXNullable',
        'collection_format' => 'setCollectionFormat',
        'description' => 'setDescription',
        'schema_reference_path' => 'setSchemaReferencePath',
        'format' => 'setFormat',
        'default' => 'setDefault',
        'multiple_of' => 'setMultipleOf',
        'maximum' => 'setMaximum',
        'exclusive_maximum' => 'setExclusiveMaximum',
        'minimum' => 'setMinimum',
        'exclusive_minimum' => 'setExclusiveMinimum',
        'max_length' => 'setMaxLength',
        'min_length' => 'setMinLength',
        'pattern' => 'setPattern',
        'max_items' => 'setMaxItems',
        'min_items' => 'setMinItems',
        'unique_items' => 'setUniqueItems',
        'max_properties' => 'setMaxProperties',
        'min_properties' => 'setMinProperties',
        'xml' => 'setXml',
        'not' => 'setNot',
        'additional_items' => 'setAdditionalItems',
        'additional_properties' => 'setAdditionalProperties',
        'items' => 'setItems',
        'properties' => 'setProperties',
        'pattern_properties' => 'setPatternProperties',
        'definitions' => 'setDefinitions',
        'x_enum_names' => 'setXEnumNames',
        'enum' => 'setEnum',
        'all_of' => 'setAllOf',
        'any_of' => 'setAnyOf',
        'one_of' => 'setOneOf'
    );

    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     * @var string[]
     */
    protected static $getters = array(
        'schema' => 'getSchema',
        'id' => 'getId',
        'title' => 'getTitle',
        'type' => 'getType',
        'discriminator' => 'getDiscriminator',
        'name' => 'getName',
        'in' => 'getIn',
        'required' => 'getRequired',
        'allow_empty_value' => 'getAllowEmptyValue',
        'schema' => 'getSchema',
        'x_nullable' => 'getXNullable',
        'collection_format' => 'getCollectionFormat',
        'description' => 'getDescription',
        'schema_reference_path' => 'getSchemaReferencePath',
        'format' => 'getFormat',
        'default' => 'getDefault',
        'multiple_of' => 'getMultipleOf',
        'maximum' => 'getMaximum',
        'exclusive_maximum' => 'getExclusiveMaximum',
        'minimum' => 'getMinimum',
        'exclusive_minimum' => 'getExclusiveMinimum',
        'max_length' => 'getMaxLength',
        'min_length' => 'getMinLength',
        'pattern' => 'getPattern',
        'max_items' => 'getMaxItems',
        'min_items' => 'getMinItems',
        'unique_items' => 'getUniqueItems',
        'max_properties' => 'getMaxProperties',
        'min_properties' => 'getMinProperties',
        'xml' => 'getXml',
        'not' => 'getNot',
        'additional_items' => 'getAdditionalItems',
        'additional_properties' => 'getAdditionalProperties',
        'items' => 'getItems',
        'properties' => 'getProperties',
        'pattern_properties' => 'getPatternProperties',
        'definitions' => 'getDefinitions',
        'x_enum_names' => 'getXEnumNames',
        'enum' => 'getEnum',
        'all_of' => 'getAllOf',
        'any_of' => 'getAnyOf',
        'one_of' => 'getOneOf'
    );

    public static function getters()
    {
        return self::$getters;
    }

    const IN_UNDEFINED = 'undefined';
    const IN_BODY = 'body';
    const IN_QUERY = 'query';
    const IN_PATH = 'path';
    const IN_HEADER = 'header';
    const IN_FORM_DATA = 'formData';
    const IN_MODELBINDING = 'modelbinding';
    const COLLECTION_FORMAT_UNDEFINED = 'undefined';
    const COLLECTION_FORMAT_CSV = 'csv';
    const COLLECTION_FORMAT_SSV = 'ssv';
    const COLLECTION_FORMAT_TSV = 'tsv';
    const COLLECTION_FORMAT_PIPES = 'pipes';
    const COLLECTION_FORMAT_MULTI = 'multi';
    

    
    /**
     * Gets allowable values of the enum
     * @return string[]
     */
    public function getInAllowableValues()
    {
        return [
            self::IN_UNDEFINED,
            self::IN_BODY,
            self::IN_QUERY,
            self::IN_PATH,
            self::IN_HEADER,
            self::IN_FORM_DATA,
            self::IN_MODELBINDING,
        ];
    }
    
    /**
     * Gets allowable values of the enum
     * @return string[]
     */
    public function getCollectionFormatAllowableValues()
    {
        return [
            self::COLLECTION_FORMAT_UNDEFINED,
            self::COLLECTION_FORMAT_CSV,
            self::COLLECTION_FORMAT_SSV,
            self::COLLECTION_FORMAT_TSV,
            self::COLLECTION_FORMAT_PIPES,
            self::COLLECTION_FORMAT_MULTI,
        ];
    }
    

    /**
     * Associative array for storing property values
     * @var mixed[]
     */
    protected $container = array();

    /**
     * Constructor
     * @param mixed[] $data Associated array of property value initalizing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['schema'] = isset($data['schema']) ? $data['schema'] : null;
        $this->container['id'] = isset($data['id']) ? $data['id'] : null;
        $this->container['title'] = isset($data['title']) ? $data['title'] : null;
        $this->container['type'] = isset($data['type']) ? $data['type'] : null;
        $this->container['discriminator'] = isset($data['discriminator']) ? $data['discriminator'] : null;
        $this->container['name'] = isset($data['name']) ? $data['name'] : null;
        $this->container['in'] = isset($data['in']) ? $data['in'] : null;
        $this->container['required'] = isset($data['required']) ? $data['required'] : null;
        $this->container['allow_empty_value'] = isset($data['allow_empty_value']) ? $data['allow_empty_value'] : null;
        $this->container['schema'] = isset($data['schema']) ? $data['schema'] : null;
        $this->container['x_nullable'] = isset($data['x_nullable']) ? $data['x_nullable'] : null;
        $this->container['collection_format'] = isset($data['collection_format']) ? $data['collection_format'] : null;
        $this->container['description'] = isset($data['description']) ? $data['description'] : null;
        $this->container['schema_reference_path'] = isset($data['schema_reference_path']) ? $data['schema_reference_path'] : null;
        $this->container['format'] = isset($data['format']) ? $data['format'] : null;
        $this->container['default'] = isset($data['default']) ? $data['default'] : null;
        $this->container['multiple_of'] = isset($data['multiple_of']) ? $data['multiple_of'] : null;
        $this->container['maximum'] = isset($data['maximum']) ? $data['maximum'] : null;
        $this->container['exclusive_maximum'] = isset($data['exclusive_maximum']) ? $data['exclusive_maximum'] : null;
        $this->container['minimum'] = isset($data['minimum']) ? $data['minimum'] : null;
        $this->container['exclusive_minimum'] = isset($data['exclusive_minimum']) ? $data['exclusive_minimum'] : null;
        $this->container['max_length'] = isset($data['max_length']) ? $data['max_length'] : null;
        $this->container['min_length'] = isset($data['min_length']) ? $data['min_length'] : null;
        $this->container['pattern'] = isset($data['pattern']) ? $data['pattern'] : null;
        $this->container['max_items'] = isset($data['max_items']) ? $data['max_items'] : null;
        $this->container['min_items'] = isset($data['min_items']) ? $data['min_items'] : null;
        $this->container['unique_items'] = isset($data['unique_items']) ? $data['unique_items'] : null;
        $this->container['max_properties'] = isset($data['max_properties']) ? $data['max_properties'] : null;
        $this->container['min_properties'] = isset($data['min_properties']) ? $data['min_properties'] : null;
        $this->container['xml'] = isset($data['xml']) ? $data['xml'] : null;
        $this->container['not'] = isset($data['not']) ? $data['not'] : null;
        $this->container['additional_items'] = isset($data['additional_items']) ? $data['additional_items'] : null;
        $this->container['additional_properties'] = isset($data['additional_properties']) ? $data['additional_properties'] : null;
        $this->container['items'] = isset($data['items']) ? $data['items'] : null;
        $this->container['properties'] = isset($data['properties']) ? $data['properties'] : null;
        $this->container['pattern_properties'] = isset($data['pattern_properties']) ? $data['pattern_properties'] : null;
        $this->container['definitions'] = isset($data['definitions']) ? $data['definitions'] : null;
        $this->container['x_enum_names'] = isset($data['x_enum_names']) ? $data['x_enum_names'] : null;
        $this->container['enum'] = isset($data['enum']) ? $data['enum'] : null;
        $this->container['all_of'] = isset($data['all_of']) ? $data['all_of'] : null;
        $this->container['any_of'] = isset($data['any_of']) ? $data['any_of'] : null;
        $this->container['one_of'] = isset($data['one_of']) ? $data['one_of'] : null;
    }

    /**
     * show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalid_properties = array();
        $allowed_values = array("undefined", "body", "query", "path", "header", "formData", "modelbinding");
        if (!in_array($this->container['in'], $allowed_values)) {
            $invalid_properties[] = "invalid value for 'in', must be one of #{allowed_values}.";
        }
        $allowed_values = array("undefined", "csv", "ssv", "tsv", "pipes", "multi");
        if (!in_array($this->container['collection_format'], $allowed_values)) {
            $invalid_properties[] = "invalid value for 'collection_format', must be one of #{allowed_values}.";
        }
        return $invalid_properties;
    }

    /**
     * validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properteis are valid
     */
    public function valid()
    {
        $allowed_values = array("undefined", "body", "query", "path", "header", "formData", "modelbinding");
        if (!in_array($this->container['in'], $allowed_values)) {
            return false;
        }
        $allowed_values = array("undefined", "csv", "ssv", "tsv", "pipes", "multi");
        if (!in_array($this->container['collection_format'], $allowed_values)) {
            return false;
        }
        return true;
    }


    /**
     * Gets schema
     * @return string
     */
    public function getSchema()
    {
        return $this->container['schema'];
    }

    /**
     * Sets schema
     * @param string $schema
     * @return $this
     */
    public function setSchema($schema)
    {
        $this->container['schema'] = $schema;

        return $this;
    }

    /**
     * Gets id
     * @return string
     */
    public function getId()
    {
        return $this->container['id'];
    }

    /**
     * Sets id
     * @param string $id
     * @return $this
     */
    public function setId($id)
    {
        $this->container['id'] = $id;

        return $this;
    }

    /**
     * Gets title
     * @return string
     */
    public function getTitle()
    {
        return $this->container['title'];
    }

    /**
     * Sets title
     * @param string $title
     * @return $this
     */
    public function setTitle($title)
    {
        $this->container['title'] = $title;

        return $this;
    }

    /**
     * Gets type
     * @return object
     */
    public function getType()
    {
        return $this->container['type'];
    }

    /**
     * Sets type
     * @param object $type
     * @return $this
     */
    public function setType($type)
    {
        $this->container['type'] = $type;

        return $this;
    }

    /**
     * Gets discriminator
     * @return string
     */
    public function getDiscriminator()
    {
        return $this->container['discriminator'];
    }

    /**
     * Sets discriminator
     * @param string $discriminator
     * @return $this
     */
    public function setDiscriminator($discriminator)
    {
        $this->container['discriminator'] = $discriminator;

        return $this;
    }

    /**
     * Gets name
     * @return string
     */
    public function getName()
    {
        return $this->container['name'];
    }

    /**
     * Sets name
     * @param string $name Gets or sets the name.
     * @return $this
     */
    public function setName($name)
    {
        $this->container['name'] = $name;

        return $this;
    }

    /**
     * Gets in
     * @return string
     */
    public function getIn()
    {
        return $this->container['in'];
    }

    /**
     * Sets in
     * @param string $in Gets or sets the kind of the parameter.
     * @return $this
     */
    public function setIn($in)
    {
        $allowed_values = array('undefined', 'body', 'query', 'path', 'header', 'formData', 'modelbinding');
        if (!in_array($in, $allowed_values)) {
            throw new \InvalidArgumentException("Invalid value for 'in', must be one of 'undefined', 'body', 'query', 'path', 'header', 'formData', 'modelbinding'");
        }
        $this->container['in'] = $in;

        return $this;
    }

    /**
     * Gets required
     * @return bool
     */
    public function getRequired()
    {
        return $this->container['required'];
    }

    /**
     * Sets required
     * @param bool $required Gets or sets a value indicating whether the parameter is required (default: false).
     * @return $this
     */
    public function setRequired($required)
    {
        $this->container['required'] = $required;

        return $this;
    }

    /**
     * Gets allow_empty_value
     * @return bool
     */
    public function getAllowEmptyValue()
    {
        return $this->container['allow_empty_value'];
    }

    /**
     * Sets allow_empty_value
     * @param bool $allow_empty_value Gets or sets a value indicating whether passing empty-valued parameters is allowed (default: false).
     * @return $this
     */
    public function setAllowEmptyValue($allow_empty_value)
    {
        $this->container['allow_empty_value'] = $allow_empty_value;

        return $this;
    }

    /**
     * Gets schema
     * @return \Swagger\Client\Model\JsonSchema4
     */
    public function getSchema()
    {
        return $this->container['schema'];
    }

    /**
     * Sets schema
     * @param \Swagger\Client\Model\JsonSchema4 $schema Gets or sets the schema which is only available when {NSwag.SwaggerParameter.Kind} == body.
     * @return $this
     */
    public function setSchema($schema)
    {
        $this->container['schema'] = $schema;

        return $this;
    }

    /**
     * Gets x_nullable
     * @return bool
     */
    public function getXNullable()
    {
        return $this->container['x_nullable'];
    }

    /**
     * Sets x_nullable
     * @param bool $x_nullable Sets a value indicating whether the parameter can be null (use IsNullable() to get a parameter's nullability).
     * @return $this
     */
    public function setXNullable($x_nullable)
    {
        $this->container['x_nullable'] = $x_nullable;

        return $this;
    }

    /**
     * Gets collection_format
     * @return string
     */
    public function getCollectionFormat()
    {
        return $this->container['collection_format'];
    }

    /**
     * Sets collection_format
     * @param string $collection_format Gets or sets the format of the array if type array is used.
     * @return $this
     */
    public function setCollectionFormat($collection_format)
    {
        $allowed_values = array('undefined', 'csv', 'ssv', 'tsv', 'pipes', 'multi');
        if (!in_array($collection_format, $allowed_values)) {
            throw new \InvalidArgumentException("Invalid value for 'collection_format', must be one of 'undefined', 'csv', 'ssv', 'tsv', 'pipes', 'multi'");
        }
        $this->container['collection_format'] = $collection_format;

        return $this;
    }

    /**
     * Gets description
     * @return string
     */
    public function getDescription()
    {
        return $this->container['description'];
    }

    /**
     * Sets description
     * @param string $description
     * @return $this
     */
    public function setDescription($description)
    {
        $this->container['description'] = $description;

        return $this;
    }

    /**
     * Gets schema_reference_path
     * @return string
     */
    public function getSchemaReferencePath()
    {
        return $this->container['schema_reference_path'];
    }

    /**
     * Sets schema_reference_path
     * @param string $schema_reference_path
     * @return $this
     */
    public function setSchemaReferencePath($schema_reference_path)
    {
        $this->container['schema_reference_path'] = $schema_reference_path;

        return $this;
    }

    /**
     * Gets format
     * @return string
     */
    public function getFormat()
    {
        return $this->container['format'];
    }

    /**
     * Sets format
     * @param string $format
     * @return $this
     */
    public function setFormat($format)
    {
        $this->container['format'] = $format;

        return $this;
    }

    /**
     * Gets default
     * @return object
     */
    public function getDefault()
    {
        return $this->container['default'];
    }

    /**
     * Sets default
     * @param object $default
     * @return $this
     */
    public function setDefault($default)
    {
        $this->container['default'] = $default;

        return $this;
    }

    /**
     * Gets multiple_of
     * @return double
     */
    public function getMultipleOf()
    {
        return $this->container['multiple_of'];
    }

    /**
     * Sets multiple_of
     * @param double $multiple_of
     * @return $this
     */
    public function setMultipleOf($multiple_of)
    {
        $this->container['multiple_of'] = $multiple_of;

        return $this;
    }

    /**
     * Gets maximum
     * @return double
     */
    public function getMaximum()
    {
        return $this->container['maximum'];
    }

    /**
     * Sets maximum
     * @param double $maximum
     * @return $this
     */
    public function setMaximum($maximum)
    {
        $this->container['maximum'] = $maximum;

        return $this;
    }

    /**
     * Gets exclusive_maximum
     * @return bool
     */
    public function getExclusiveMaximum()
    {
        return $this->container['exclusive_maximum'];
    }

    /**
     * Sets exclusive_maximum
     * @param bool $exclusive_maximum
     * @return $this
     */
    public function setExclusiveMaximum($exclusive_maximum)
    {
        $this->container['exclusive_maximum'] = $exclusive_maximum;

        return $this;
    }

    /**
     * Gets minimum
     * @return double
     */
    public function getMinimum()
    {
        return $this->container['minimum'];
    }

    /**
     * Sets minimum
     * @param double $minimum
     * @return $this
     */
    public function setMinimum($minimum)
    {
        $this->container['minimum'] = $minimum;

        return $this;
    }

    /**
     * Gets exclusive_minimum
     * @return bool
     */
    public function getExclusiveMinimum()
    {
        return $this->container['exclusive_minimum'];
    }

    /**
     * Sets exclusive_minimum
     * @param bool $exclusive_minimum
     * @return $this
     */
    public function setExclusiveMinimum($exclusive_minimum)
    {
        $this->container['exclusive_minimum'] = $exclusive_minimum;

        return $this;
    }

    /**
     * Gets max_length
     * @return int
     */
    public function getMaxLength()
    {
        return $this->container['max_length'];
    }

    /**
     * Sets max_length
     * @param int $max_length
     * @return $this
     */
    public function setMaxLength($max_length)
    {
        $this->container['max_length'] = $max_length;

        return $this;
    }

    /**
     * Gets min_length
     * @return int
     */
    public function getMinLength()
    {
        return $this->container['min_length'];
    }

    /**
     * Sets min_length
     * @param int $min_length
     * @return $this
     */
    public function setMinLength($min_length)
    {
        $this->container['min_length'] = $min_length;

        return $this;
    }

    /**
     * Gets pattern
     * @return string
     */
    public function getPattern()
    {
        return $this->container['pattern'];
    }

    /**
     * Sets pattern
     * @param string $pattern
     * @return $this
     */
    public function setPattern($pattern)
    {
        $this->container['pattern'] = $pattern;

        return $this;
    }

    /**
     * Gets max_items
     * @return int
     */
    public function getMaxItems()
    {
        return $this->container['max_items'];
    }

    /**
     * Sets max_items
     * @param int $max_items
     * @return $this
     */
    public function setMaxItems($max_items)
    {
        $this->container['max_items'] = $max_items;

        return $this;
    }

    /**
     * Gets min_items
     * @return int
     */
    public function getMinItems()
    {
        return $this->container['min_items'];
    }

    /**
     * Sets min_items
     * @param int $min_items
     * @return $this
     */
    public function setMinItems($min_items)
    {
        $this->container['min_items'] = $min_items;

        return $this;
    }

    /**
     * Gets unique_items
     * @return bool
     */
    public function getUniqueItems()
    {
        return $this->container['unique_items'];
    }

    /**
     * Sets unique_items
     * @param bool $unique_items
     * @return $this
     */
    public function setUniqueItems($unique_items)
    {
        $this->container['unique_items'] = $unique_items;

        return $this;
    }

    /**
     * Gets max_properties
     * @return int
     */
    public function getMaxProperties()
    {
        return $this->container['max_properties'];
    }

    /**
     * Sets max_properties
     * @param int $max_properties
     * @return $this
     */
    public function setMaxProperties($max_properties)
    {
        $this->container['max_properties'] = $max_properties;

        return $this;
    }

    /**
     * Gets min_properties
     * @return int
     */
    public function getMinProperties()
    {
        return $this->container['min_properties'];
    }

    /**
     * Sets min_properties
     * @param int $min_properties
     * @return $this
     */
    public function setMinProperties($min_properties)
    {
        $this->container['min_properties'] = $min_properties;

        return $this;
    }

    /**
     * Gets xml
     * @return \Swagger\Client\Model\JsonXmlObject
     */
    public function getXml()
    {
        return $this->container['xml'];
    }

    /**
     * Sets xml
     * @param \Swagger\Client\Model\JsonXmlObject $xml
     * @return $this
     */
    public function setXml($xml)
    {
        $this->container['xml'] = $xml;

        return $this;
    }

    /**
     * Gets not
     * @return \Swagger\Client\Model\JsonSchema4
     */
    public function getNot()
    {
        return $this->container['not'];
    }

    /**
     * Sets not
     * @param \Swagger\Client\Model\JsonSchema4 $not
     * @return $this
     */
    public function setNot($not)
    {
        $this->container['not'] = $not;

        return $this;
    }

    /**
     * Gets additional_items
     * @return object
     */
    public function getAdditionalItems()
    {
        return $this->container['additional_items'];
    }

    /**
     * Sets additional_items
     * @param object $additional_items
     * @return $this
     */
    public function setAdditionalItems($additional_items)
    {
        $this->container['additional_items'] = $additional_items;

        return $this;
    }

    /**
     * Gets additional_properties
     * @return object
     */
    public function getAdditionalProperties()
    {
        return $this->container['additional_properties'];
    }

    /**
     * Sets additional_properties
     * @param object $additional_properties
     * @return $this
     */
    public function setAdditionalProperties($additional_properties)
    {
        $this->container['additional_properties'] = $additional_properties;

        return $this;
    }

    /**
     * Gets items
     * @return object
     */
    public function getItems()
    {
        return $this->container['items'];
    }

    /**
     * Sets items
     * @param object $items
     * @return $this
     */
    public function setItems($items)
    {
        $this->container['items'] = $items;

        return $this;
    }

    /**
     * Gets properties
     * @return map[string,\Swagger\Client\Model\JsonSchema4]
     */
    public function getProperties()
    {
        return $this->container['properties'];
    }

    /**
     * Sets properties
     * @param map[string,\Swagger\Client\Model\JsonSchema4] $properties
     * @return $this
     */
    public function setProperties($properties)
    {
        $this->container['properties'] = $properties;

        return $this;
    }

    /**
     * Gets pattern_properties
     * @return map[string,\Swagger\Client\Model\JsonSchema4]
     */
    public function getPatternProperties()
    {
        return $this->container['pattern_properties'];
    }

    /**
     * Sets pattern_properties
     * @param map[string,\Swagger\Client\Model\JsonSchema4] $pattern_properties
     * @return $this
     */
    public function setPatternProperties($pattern_properties)
    {
        $this->container['pattern_properties'] = $pattern_properties;

        return $this;
    }

    /**
     * Gets definitions
     * @return map[string,\Swagger\Client\Model\JsonSchema4]
     */
    public function getDefinitions()
    {
        return $this->container['definitions'];
    }

    /**
     * Sets definitions
     * @param map[string,\Swagger\Client\Model\JsonSchema4] $definitions
     * @return $this
     */
    public function setDefinitions($definitions)
    {
        $this->container['definitions'] = $definitions;

        return $this;
    }

    /**
     * Gets x_enum_names
     * @return string[]
     */
    public function getXEnumNames()
    {
        return $this->container['x_enum_names'];
    }

    /**
     * Sets x_enum_names
     * @param string[] $x_enum_names
     * @return $this
     */
    public function setXEnumNames($x_enum_names)
    {
        $this->container['x_enum_names'] = $x_enum_names;

        return $this;
    }

    /**
     * Gets enum
     * @return object[]
     */
    public function getEnum()
    {
        return $this->container['enum'];
    }

    /**
     * Sets enum
     * @param object[] $enum
     * @return $this
     */
    public function setEnum($enum)
    {
        $this->container['enum'] = $enum;

        return $this;
    }

    /**
     * Gets all_of
     * @return \Swagger\Client\Model\JsonSchema4[]
     */
    public function getAllOf()
    {
        return $this->container['all_of'];
    }

    /**
     * Sets all_of
     * @param \Swagger\Client\Model\JsonSchema4[] $all_of
     * @return $this
     */
    public function setAllOf($all_of)
    {
        $this->container['all_of'] = $all_of;

        return $this;
    }

    /**
     * Gets any_of
     * @return \Swagger\Client\Model\JsonSchema4[]
     */
    public function getAnyOf()
    {
        return $this->container['any_of'];
    }

    /**
     * Sets any_of
     * @param \Swagger\Client\Model\JsonSchema4[] $any_of
     * @return $this
     */
    public function setAnyOf($any_of)
    {
        $this->container['any_of'] = $any_of;

        return $this;
    }

    /**
     * Gets one_of
     * @return \Swagger\Client\Model\JsonSchema4[]
     */
    public function getOneOf()
    {
        return $this->container['one_of'];
    }

    /**
     * Sets one_of
     * @param \Swagger\Client\Model\JsonSchema4[] $one_of
     * @return $this
     */
    public function setOneOf($one_of)
    {
        $this->container['one_of'] = $one_of;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     * @param  integer $offset Offset
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     * @param  integer $offset Offset
     * @return mixed
     */
    public function offsetGet($offset)
    {
        return isset($this->container[$offset]) ? $this->container[$offset] : null;
    }

    /**
     * Sets value based on offset.
     * @param  integer $offset Offset
     * @param  mixed   $value  Value to be set
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     * @param  integer $offset Offset
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Gets the string presentation of the object
     * @return string
     */
    public function __toString()
    {
        if (defined('JSON_PRETTY_PRINT')) { // use JSON pretty print
            return json_encode(\Swagger\Client\ObjectSerializer::sanitizeForSerialization($this), JSON_PRETTY_PRINT);
        }

        return json_encode(\Swagger\Client\ObjectSerializer::sanitizeForSerialization($this));
    }
}
