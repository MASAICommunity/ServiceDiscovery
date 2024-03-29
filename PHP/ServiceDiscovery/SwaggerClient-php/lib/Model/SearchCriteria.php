<?php
/**
 * SearchCriteria
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
 * SearchCriteria Class Doc Comment
 *
 * @category    Class
 * @description Search request object
 * @package     Swagger\Client
 * @author      http://github.com/swagger-api/swagger-codegen
 * @license     http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class SearchCriteria implements ArrayAccess
{
    /**
      * The original name of the model.
      * @var string
      */
    protected static $swaggerModelName = 'SearchCriteria';

    /**
      * Array of property to type mappings. Used for (de)serialization
      * @var string[]
      */
    protected static $swaggerTypes = array(
        'environment' => 'string',
        'service_search_criteria' => '\Swagger\Client\Model\DiscoveryRequest[]'
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
        'environment' => 'environment',
        'service_search_criteria' => 'serviceSearchCriteria'
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
        'environment' => 'setEnvironment',
        'service_search_criteria' => 'setServiceSearchCriteria'
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
        'environment' => 'getEnvironment',
        'service_search_criteria' => 'getServiceSearchCriteria'
    );

    public static function getters()
    {
        return self::$getters;
    }

    const ENVIRONMENT_SANDBOX = 'SANDBOX';
    const ENVIRONMENT_PRODUCTION = 'PRODUCTION';
    

    
    /**
     * Gets allowable values of the enum
     * @return string[]
     */
    public function getEnvironmentAllowableValues()
    {
        return [
            self::ENVIRONMENT_SANDBOX,
            self::ENVIRONMENT_PRODUCTION,
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
        $this->container['environment'] = isset($data['environment']) ? $data['environment'] : null;
        $this->container['service_search_criteria'] = isset($data['service_search_criteria']) ? $data['service_search_criteria'] : null;
    }

    /**
     * show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalid_properties = array();
        if ($this->container['environment'] === null) {
            $invalid_properties[] = "'environment' can't be null";
        }
        $allowed_values = array("SANDBOX", "PRODUCTION");
        if (!in_array($this->container['environment'], $allowed_values)) {
            $invalid_properties[] = "invalid value for 'environment', must be one of #{allowed_values}.";
        }
        if ($this->container['service_search_criteria'] === null) {
            $invalid_properties[] = "'service_search_criteria' can't be null";
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
        if ($this->container['environment'] === null) {
            return false;
        }
        $allowed_values = array("SANDBOX", "PRODUCTION");
        if (!in_array($this->container['environment'], $allowed_values)) {
            return false;
        }
        if ($this->container['service_search_criteria'] === null) {
            return false;
        }
        return true;
    }


    /**
     * Gets environment
     * @return string
     */
    public function getEnvironment()
    {
        return $this->container['environment'];
    }

    /**
     * Sets environment
     * @param string $environment Environment to search services
     * @return $this
     */
    public function setEnvironment($environment)
    {
        $allowed_values = array('SANDBOX', 'PRODUCTION');
        if (!in_array($environment, $allowed_values)) {
            throw new \InvalidArgumentException("Invalid value for 'environment', must be one of 'SANDBOX', 'PRODUCTION'");
        }
        $this->container['environment'] = $environment;

        return $this;
    }

    /**
     * Gets service_search_criteria
     * @return \Swagger\Client\Model\DiscoveryRequest[]
     */
    public function getServiceSearchCriteria()
    {
        return $this->container['service_search_criteria'];
    }

    /**
     * Sets service_search_criteria
     * @param \Swagger\Client\Model\DiscoveryRequest[] $service_search_criteria List containing each type of service to look for
     * @return $this
     */
    public function setServiceSearchCriteria($service_search_criteria)
    {
        $this->container['service_search_criteria'] = $service_search_criteria;

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
