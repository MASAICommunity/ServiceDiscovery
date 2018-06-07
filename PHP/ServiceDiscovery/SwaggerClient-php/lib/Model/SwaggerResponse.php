<?php
/**
 * SwaggerResponse
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
 * SwaggerResponse Class Doc Comment
 *
 * @category    Class
 * @description The Swagger response.
 * @package     Swagger\Client
 * @author      http://github.com/swagger-api/swagger-codegen
 * @license     http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class SwaggerResponse implements ArrayAccess
{
    /**
      * The original name of the model.
      * @var string
      */
    protected static $swaggerModelName = 'SwaggerResponse';

    /**
      * Array of property to type mappings. Used for (de)serialization
      * @var string[]
      */
    protected static $swaggerTypes = array(
        'description' => 'string',
        'schema' => '\Swagger\Client\Model\JsonSchema4',
        'headers' => 'map[string,\Swagger\Client\Model\JsonSchema4]',
        'x_nullable' => 'bool',
        'x_expected_schemas' => '\Swagger\Client\Model\JsonExpectedSchema[]'
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
        'description' => 'description',
        'schema' => 'schema',
        'headers' => 'headers',
        'x_nullable' => 'x-nullable',
        'x_expected_schemas' => 'x-expectedSchemas'
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
        'description' => 'setDescription',
        'schema' => 'setSchema',
        'headers' => 'setHeaders',
        'x_nullable' => 'setXNullable',
        'x_expected_schemas' => 'setXExpectedSchemas'
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
        'description' => 'getDescription',
        'schema' => 'getSchema',
        'headers' => 'getHeaders',
        'x_nullable' => 'getXNullable',
        'x_expected_schemas' => 'getXExpectedSchemas'
    );

    public static function getters()
    {
        return self::$getters;
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
        $this->container['description'] = isset($data['description']) ? $data['description'] : null;
        $this->container['schema'] = isset($data['schema']) ? $data['schema'] : null;
        $this->container['headers'] = isset($data['headers']) ? $data['headers'] : null;
        $this->container['x_nullable'] = isset($data['x_nullable']) ? $data['x_nullable'] : null;
        $this->container['x_expected_schemas'] = isset($data['x_expected_schemas']) ? $data['x_expected_schemas'] : null;
    }

    /**
     * show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalid_properties = array();
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
        return true;
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
     * @param string $description Gets or sets the response's description.
     * @return $this
     */
    public function setDescription($description)
    {
        $this->container['description'] = $description;

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
     * @param \Swagger\Client\Model\JsonSchema4 $schema Gets or sets the response schema.
     * @return $this
     */
    public function setSchema($schema)
    {
        $this->container['schema'] = $schema;

        return $this;
    }

    /**
     * Gets headers
     * @return map[string,\Swagger\Client\Model\JsonSchema4]
     */
    public function getHeaders()
    {
        return $this->container['headers'];
    }

    /**
     * Sets headers
     * @param map[string,\Swagger\Client\Model\JsonSchema4] $headers Gets or sets the headers.
     * @return $this
     */
    public function setHeaders($headers)
    {
        $this->container['headers'] = $headers;

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
     * @param bool $x_nullable Sets a value indicating whether the response can be null (use IsNullable() to get a parameter's nullability).
     * @return $this
     */
    public function setXNullable($x_nullable)
    {
        $this->container['x_nullable'] = $x_nullable;

        return $this;
    }

    /**
     * Gets x_expected_schemas
     * @return \Swagger\Client\Model\JsonExpectedSchema[]
     */
    public function getXExpectedSchemas()
    {
        return $this->container['x_expected_schemas'];
    }

    /**
     * Sets x_expected_schemas
     * @param \Swagger\Client\Model\JsonExpectedSchema[] $x_expected_schemas Gets or sets the expected child schemas of the base schema (can be used for generating enhanced typings/documentation).
     * @return $this
     */
    public function setXExpectedSchemas($x_expected_schemas)
    {
        $this->container['x_expected_schemas'] = $x_expected_schemas;

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
