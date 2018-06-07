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
    define(['DiscoverySearchEngine/ApiClient'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'));
  } else {
    // Browser globals (root is window)
    if (!root.DiscoverySearchEngine) {
      root.DiscoverySearchEngine = {};
    }
    root.DiscoverySearchEngine.JsonXmlObject = factory(root.DiscoverySearchEngine.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';




  /**
   * The JsonXmlObject model module.
   * @module DiscoverySearchEngine/DiscoverySearchEngine/JsonXmlObject
   * @version v1
   */

  /**
   * Constructs a new <code>JsonXmlObject</code>.
   * @alias module:DiscoverySearchEngine/DiscoverySearchEngine/JsonXmlObject
   * @class
   */
  var exports = function() {
    var _this = this;






  };

  /**
   * Constructs a <code>JsonXmlObject</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:DiscoverySearchEngine/DiscoverySearchEngine/JsonXmlObject} obj Optional instance to populate.
   * @return {module:DiscoverySearchEngine/DiscoverySearchEngine/JsonXmlObject} The populated <code>JsonXmlObject</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
      if (data.hasOwnProperty('wrapped')) {
        obj['wrapped'] = ApiClient.convertToType(data['wrapped'], 'Boolean');
      }
      if (data.hasOwnProperty('namespace')) {
        obj['namespace'] = ApiClient.convertToType(data['namespace'], 'String');
      }
      if (data.hasOwnProperty('prefix')) {
        obj['prefix'] = ApiClient.convertToType(data['prefix'], 'String');
      }
      if (data.hasOwnProperty('attribute')) {
        obj['attribute'] = ApiClient.convertToType(data['attribute'], 'Boolean');
      }
    }
    return obj;
  }

  /**
   * @member {String} name
   */
  exports.prototype['name'] = undefined;
  /**
   * @member {Boolean} wrapped
   */
  exports.prototype['wrapped'] = undefined;
  /**
   * @member {String} namespace
   */
  exports.prototype['namespace'] = undefined;
  /**
   * @member {String} prefix
   */
  exports.prototype['prefix'] = undefined;
  /**
   * @member {Boolean} attribute
   */
  exports.prototype['attribute'] = undefined;



  return exports;
}));


