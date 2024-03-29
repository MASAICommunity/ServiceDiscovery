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
    root.DiscoverySearchEngine.Location = factory(root.DiscoverySearchEngine.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';




  /**
   * The Location model module.
   * @module DiscoverySearchEngine/DiscoverySearchEngine/Location
   * @version v1
   */

  /**
   * Constructs a new <code>Location</code>.
   * Location information (Search for services within one box area)
   * @alias module:DiscoverySearchEngine/DiscoverySearchEngine/Location
   * @class
   */
  var exports = function() {
    var _this = this;







  };

  /**
   * Constructs a <code>Location</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:DiscoverySearchEngine/DiscoverySearchEngine/Location} obj Optional instance to populate.
   * @return {module:DiscoverySearchEngine/DiscoverySearchEngine/Location} The populated <code>Location</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('minLatitude')) {
        obj['minLatitude'] = ApiClient.convertToType(data['minLatitude'], 'Number');
      }
      if (data.hasOwnProperty('minLongitude')) {
        obj['minLongitude'] = ApiClient.convertToType(data['minLongitude'], 'Number');
      }
      if (data.hasOwnProperty('maxLatitude')) {
        obj['maxLatitude'] = ApiClient.convertToType(data['maxLatitude'], 'Number');
      }
      if (data.hasOwnProperty('maxLongitude')) {
        obj['maxLongitude'] = ApiClient.convertToType(data['maxLongitude'], 'Number');
      }
      if (data.hasOwnProperty('countries')) {
        obj['countries'] = ApiClient.convertToType(data['countries'], ['String']);
      }
      if (data.hasOwnProperty('cities')) {
        obj['cities'] = ApiClient.convertToType(data['cities'], ['String']);
      }
    }
    return obj;
  }

  /**
   * Bottom left latitude
   * @member {Number} minLatitude
   */
  exports.prototype['minLatitude'] = undefined;
  /**
   * Bottom left longitude
   * @member {Number} minLongitude
   */
  exports.prototype['minLongitude'] = undefined;
  /**
   * Top right latitude
   * @member {Number} maxLatitude
   */
  exports.prototype['maxLatitude'] = undefined;
  /**
   * Top right longitude
   * @member {Number} maxLongitude
   */
  exports.prototype['maxLongitude'] = undefined;
  /**
   * List of ISO 3166-1 Country Codes
   * @member {Array.<String>} countries
   */
  exports.prototype['countries'] = undefined;
  /**
   * List of cities to search for
   * @member {Array.<String>} cities
   */
  exports.prototype['cities'] = undefined;



  return exports;
}));


