/**
 * MASAI Service Discovery API
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.3.1
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['DiscoverySearchEngine/ApiClient', 'DiscoverySearchEngine/DiscoverySearchEngine/Contact', 'DiscoverySearchEngine/DiscoverySearchEngine/Maintainers', 'DiscoverySearchEngine/DiscoverySearchEngine/Properties', 'DiscoverySearchEngine/DiscoverySearchEngine/SwaggerDocument'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./Contact'), require('./Maintainers'), require('./Properties'), require('./SwaggerDocument'));
  } else {
    // Browser globals (root is window)
    if (!root.DiscoverySearchEngine) {
      root.DiscoverySearchEngine = {};
    }
    root.DiscoverySearchEngine.Data = factory(root.DiscoverySearchEngine.ApiClient, root.DiscoverySearchEngine.Contact, root.DiscoverySearchEngine.Maintainers, root.DiscoverySearchEngine.Properties, root.DiscoverySearchEngine.SwaggerDocument);
  }
}(this, function(ApiClient, Contact, Maintainers, Properties, SwaggerDocument) {
  'use strict';




  /**
   * The Data model module.
   * @module DiscoverySearchEngine/DiscoverySearchEngine/Data
   * @version v1
   */

  /**
   * Constructs a new <code>Data</code>.
   * Data
   * @alias module:DiscoverySearchEngine/DiscoverySearchEngine/Data
   * @class
   */
  var exports = function() {
    var _this = this;






















  };

  /**
   * Constructs a <code>Data</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:DiscoverySearchEngine/DiscoverySearchEngine/Data} obj Optional instance to populate.
   * @return {module:DiscoverySearchEngine/DiscoverySearchEngine/Data} The populated <code>Data</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('planConditions')) {
        obj['planConditions'] = ApiClient.convertToType(data['planConditions'], 'String');
      }
      if (data.hasOwnProperty('swagger')) {
        obj['swagger'] = SwaggerDocument.constructFromObject(data['swagger']);
      }
      if (data.hasOwnProperty('properties')) {
        obj['properties'] = ApiClient.convertToType(data['properties'], [Properties]);
      }
      if (data.hasOwnProperty('contact')) {
        obj['contact'] = ApiClient.convertToType(data['contact'], [Contact]);
      }
      if (data.hasOwnProperty('maintainers')) {
        obj['maintainers'] = ApiClient.convertToType(data['maintainers'], [Maintainers]);
      }
      if (data.hasOwnProperty('tags')) {
        obj['tags'] = ApiClient.convertToType(data['tags'], ['String']);
      }
      if (data.hasOwnProperty('integrationMode')) {
        obj['integrationMode'] = ApiClient.convertToType(data['integrationMode'], 'String');
      }
      if (data.hasOwnProperty('levelOfService')) {
        obj['levelOfService'] = ApiClient.convertToType(data['levelOfService'], ['String']);
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
      if (data.hasOwnProperty('description')) {
        obj['description'] = ApiClient.convertToType(data['description'], 'String');
      }
      if (data.hasOwnProperty('image')) {
        obj['image'] = ApiClient.convertToType(data['image'], 'String');
      }
      if (data.hasOwnProperty('baseURL')) {
        obj['baseURL'] = ApiClient.convertToType(data['baseURL'], 'String');
      }
      if (data.hasOwnProperty('humanURL')) {
        obj['humanURL'] = ApiClient.convertToType(data['humanURL'], 'String');
      }
      if (data.hasOwnProperty('appName')) {
        obj['appName'] = ApiClient.convertToType(data['appName'], 'String');
      }
      if (data.hasOwnProperty('packageName')) {
        obj['packageName'] = ApiClient.convertToType(data['packageName'], 'String');
      }
      if (data.hasOwnProperty('deeplinkURL')) {
        obj['deeplinkURL'] = ApiClient.convertToType(data['deeplinkURL'], 'String');
      }
      if (data.hasOwnProperty('planConditionsUrl')) {
        obj['planConditionsUrl'] = ApiClient.convertToType(data['planConditionsUrl'], 'String');
      }
      if (data.hasOwnProperty('updatedAt')) {
        obj['updatedAt'] = ApiClient.convertToType(data['updatedAt'], 'String');
      }
      if (data.hasOwnProperty('signatureKey')) {
        obj['signatureKey'] = ApiClient.convertToType(data['signatureKey'], 'String');
      }
      if (data.hasOwnProperty('authoritative')) {
        obj['authoritative'] = ApiClient.convertToType(data['authoritative'], 'String');
      }
      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
    }
    return obj;
  }

  /**
   * Plan conditions of the service
   * @member {module:DiscoverySearchEngine/DiscoverySearchEngine/Data.PlanConditionsEnum} planConditions
   */
  exports.prototype['planConditions'] = undefined;
  /**
   * Swagger file information
   * @member {module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerDocument} swagger
   */
  exports.prototype['swagger'] = undefined;
  /**
   * Properties service information
   * @member {Array.<module:DiscoverySearchEngine/DiscoverySearchEngine/Properties>} properties
   */
  exports.prototype['properties'] = undefined;
  /**
   * Contact service information
   * @member {Array.<module:DiscoverySearchEngine/DiscoverySearchEngine/Contact>} contact
   */
  exports.prototype['contact'] = undefined;
  /**
   * Maintainers service informatoin
   * @member {Array.<module:DiscoverySearchEngine/DiscoverySearchEngine/Maintainers>} maintainers
   */
  exports.prototype['maintainers'] = undefined;
  /**
   * Tags service information
   * @member {Array.<String>} tags
   */
  exports.prototype['tags'] = undefined;
  /**
   * Information related to how the service is integrated
   * @member {String} integrationMode
   */
  exports.prototype['integrationMode'] = undefined;
  /**
   * Level of service provided
   * @member {Array.<module:DiscoverySearchEngine/DiscoverySearchEngine/Data.LevelOfServiceEnum>} levelOfService
   */
  exports.prototype['levelOfService'] = undefined;
  /**
   * Name of the service
   * @member {String} name
   */
  exports.prototype['name'] = undefined;
  /**
   * Description of the service
   * @member {String} description
   */
  exports.prototype['description'] = undefined;
  /**
   * Image related of the service
   * @member {String} image
   */
  exports.prototype['image'] = undefined;
  /**
   * Base URL of the service
   * @member {String} baseURL
   */
  exports.prototype['baseURL'] = undefined;
  /**
   * URL of the human readable documentation
   * @member {String} humanURL
   */
  exports.prototype['humanURL'] = undefined;
  /**
   * App name of the service if the integration mode is \"app\". E.g.: \"Travel Concierge\"
   * @member {String} appName
   */
  exports.prototype['appName'] = undefined;
  /**
   * Package name of the service if the integration mode is \"app\". E.g.: \"com.serviceprovider.travelconcierge\"
   * @member {String} packageName
   */
  exports.prototype['packageName'] = undefined;
  /**
   * Base deeplink URL of the service to integrate directly with application. (This attribute will appear only if integration mode is \"app\".)
   * @member {String} deeplinkURL
   */
  exports.prototype['deeplinkURL'] = undefined;
  /**
   * Plan conditions URL with human readable information
   * @member {String} planConditionsUrl
   */
  exports.prototype['planConditionsUrl'] = undefined;
  /**
   * Timestamp of when service was updated
   * @member {String} updatedAt
   */
  exports.prototype['updatedAt'] = undefined;
  /**
   * Service Descriptor Signature Key
   * @member {String} signatureKey
   */
  exports.prototype['signatureKey'] = undefined;
  /**
   * If the root domain of the service described by the entry is on the same DNS domain or on a DNS subdomain thereof.
   * @member {String} authoritative
   */
  exports.prototype['authoritative'] = undefined;
  /**
   * Service descriptor identifier
   * @member {String} id
   */
  exports.prototype['id'] = undefined;


  /**
   * Allowed values for the <code>planConditions</code> property.
   * @enum {String}
   * @readonly
   */
  exports.PlanConditionsEnum = {
    /**
     * value: "free"
     * @const
     */
    "free": "free",
    /**
     * value: "paid"
     * @const
     */
    "paid": "paid"  };

  /**
   * Allowed values for the <code>levelOfService</code> property.
   * @enum {String}
   * @readonly
   */
  exports.LevelOfServiceEnum = {
    /**
     * value: "VIP"
     * @const
     */
    "VIP": "VIP",
    /**
     * value: "Economy"
     * @const
     */
    "Economy": "Economy",
    /**
     * value: "Regular"
     * @const
     */
    "Regular": "Regular",
    /**
     * value: "Luxury"
     * @const
     */
    "Luxury": "Luxury",
    /**
     * value: "Executive"
     * @const
     */
    "Executive": "Executive",
    /**
     * value: "Exclusive"
     * @const
     */
    "Exclusive": "Exclusive",
    /**
     * value: "Deluxe"
     * @const
     */
    "Deluxe": "Deluxe"  };


  return exports;
}));


