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
    root.DiscoverySearchEngine.SwaggerLicense = factory(root.DiscoverySearchEngine.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';




  /**
   * The SwaggerLicense model module.
   * @module DiscoverySearchEngine/DiscoverySearchEngine/SwaggerLicense
   * @version v1
   */

  /**
   * Constructs a new <code>SwaggerLicense</code>.
   * The license information.
   * @alias module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerLicense
   * @class
   */
  var exports = function() {
    var _this = this;



  };

  /**
   * Constructs a <code>SwaggerLicense</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerLicense} obj Optional instance to populate.
   * @return {module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerLicense} The populated <code>SwaggerLicense</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
      if (data.hasOwnProperty('url')) {
        obj['url'] = ApiClient.convertToType(data['url'], 'String');
      }
    }
    return obj;
  }

  /**
   * Gets or sets the name.
   * @member {String} name
   */
  exports.prototype['name'] = undefined;
  /**
   * Gets or sets the license URL.
   * @member {String} url
   */
  exports.prototype['url'] = undefined;



  return exports;
}));


