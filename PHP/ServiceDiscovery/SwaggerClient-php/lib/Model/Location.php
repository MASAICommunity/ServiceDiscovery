<?php
/**
 * Location
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
 * Location Class Doc Comment
 *
 * @category    Class
 * @description Location information (Search for services within one box area)
 * @package     Swagger\Client
 * @author      http://github.com/swagger-api/swagger-codegen
 * @license     http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class Location implements ArrayAccess
{
    /**
      * The original name of the model.
      * @var string
      */
    protected static $swaggerModelName = 'Location';

    /**
      * Array of property to type mappings. Used for (de)serialization
      * @var string[]
      */
    protected static $swaggerTypes = array(
        'min_latitude' => 'double',
        'min_longitude' => 'double',
        'max_latitude' => 'double',
        'max_longitude' => 'double',
        'countries' => 'string[]',
        'cities' => 'string[]'
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
        'min_latitude' => 'minLatitude',
        'min_longitude' => 'minLongitude',
        'max_latitude' => 'maxLatitude',
        'max_longitude' => 'maxLongitude',
        'countries' => 'countries',
        'cities' => 'cities'
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
        'min_latitude' => 'setMinLatitude',
        'min_longitude' => 'setMinLongitude',
        'max_latitude' => 'setMaxLatitude',
        'max_longitude' => 'setMaxLongitude',
        'countries' => 'setCountries',
        'cities' => 'setCities'
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
        'min_latitude' => 'getMinLatitude',
        'min_longitude' => 'getMinLongitude',
        'max_latitude' => 'getMaxLatitude',
        'max_longitude' => 'getMaxLongitude',
        'countries' => 'getCountries',
        'cities' => 'getCities'
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
        $this->container['min_latitude'] = isset($data['min_latitude']) ? $data['min_latitude'] : null;
        $this->container['min_longitude'] = isset($data['min_longitude']) ? $data['min_longitude'] : null;
        $this->container['max_latitude'] = isset($data['max_latitude']) ? $data['max_latitude'] : null;
        $this->container['max_longitude'] = isset($data['max_longitude']) ? $data['max_longitude'] : null;
        $this->container['countries'] = isset($data['countries']) ? $data['countries'] : null;
        $this->container['cities'] = isset($data['cities']) ? $data['cities'] : null;
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
     * Gets min_latitude
     * @return double
     */
    public function getMinLatitude()
    {
        return $this->container['min_latitude'];
    }

    /**
     * Sets min_latitude
     * @param double $min_latitude Bottom left latitude
     * @return $this
     */
    public function setMinLatitude($min_latitude)
    {
        $this->container['min_latitude'] = $min_latitude;

        return $this;
    }

    /**
     * Gets min_longitude
     * @return double
     */
    public function getMinLongitude()
    {
        return $this->container['min_longitude'];
    }

    /**
     * Sets min_longitude
     * @param double $min_longitude Bottom left longitude
     * @return $this
     */
    public function setMinLongitude($min_longitude)
    {
        $this->container['min_longitude'] = $min_longitude;

        return $this;
    }

    /**
     * Gets max_latitude
     * @return double
     */
    public function getMaxLatitude()
    {
        return $this->container['max_latitude'];
    }

    /**
     * Sets max_latitude
     * @param double $max_latitude Top right latitude
     * @return $this
     */
    public function setMaxLatitude($max_latitude)
    {
        $this->container['max_latitude'] = $max_latitude;

        return $this;
    }

    /**
     * Gets max_longitude
     * @return double
     */
    public function getMaxLongitude()
    {
        return $this->container['max_longitude'];
    }

    /**
     * Sets max_longitude
     * @param double $max_longitude Top right longitude
     * @return $this
     */
    public function setMaxLongitude($max_longitude)
    {
        $this->container['max_longitude'] = $max_longitude;

        return $this;
    }

    /**
     * Gets countries
     * @return string[]
     */
    public function getCountries()
    {
        return $this->container['countries'];
    }

    /**
     * Sets countries
     * @param string[] $countries List of ISO 3166-1 Country Codes
     * @return $this
     */
    public function setCountries($countries)
    {
        $this->container['countries'] = $countries;

        return $this;
    }

    /**
     * Gets cities
     * @return string[]
     */
    public function getCities()
    {
        return $this->container['cities'];
    }

    /**
     * Sets cities
     * @param string[] $cities List of cities to search for
     * @return $this
     */
    public function setCities($cities)
    {
        $this->container['cities'] = $cities;

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
