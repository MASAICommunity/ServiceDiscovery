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
    define(['DiscoverySearchEngine/ApiClient', 'DiscoverySearchEngine/DiscoverySearchEngine/JsonSchema4'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./JsonSchema4'));
  } else {
    // Browser globals (root is window)
    if (!root.DiscoverySearchEngine) {
      root.DiscoverySearchEngine = {};
    }
    root.DiscoverySearchEngine.JsonExpectedSchema = factory(root.DiscoverySearchEngine.ApiClient, root.DiscoverySearchEngine.JsonSchema4);
  }
}(this, function(ApiClient, JsonSchema4) {
  'use strict';




  /**
   * The JsonExpectedSchema model module.
   * @module DiscoverySearchEngine/DiscoverySearchEngine/JsonExpectedSchema
   * @version v1
   */

  /**
   * Constructs a new <code>JsonExpectedSchema</code>.
   * 
   * @alias module:DiscoverySearchEngine/DiscoverySearchEngine/JsonExpectedSchema
   * @class
   */
  var exports = function() {
    var _this = this;



  };

  /**
   * Constructs a <code>JsonExpectedSchema</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:DiscoverySearchEngine/DiscoverySearchEngine/JsonExpectedSchema} obj Optional instance to populate.
   * @return {module:DiscoverySearchEngine/DiscoverySearchEngine/JsonExpectedSchema} The populated <code>JsonExpectedSchema</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('description')) {
        obj['description'] = ApiClient.convertToType(data['description'], 'String');
      }
      if (data.hasOwnProperty('schema')) {
        obj['schema'] = JsonSchema4.constructFromObject(data['schema']);
      }
    }
    return obj;
  }

  /**
   * Gets or sets the description.
   * @member {String} description
   */
  exports.prototype['description'] = undefined;
  /**
   * Gets or sets the schema.
   * @member {module:DiscoverySearchEngine/DiscoverySearchEngine/JsonSchema4} schema
   */
  exports.prototype['schema'] = undefined;



  return exports;
}));


