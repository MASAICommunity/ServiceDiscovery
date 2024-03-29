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
    define(['DiscoverySearchEngine/ApiClient', 'DiscoverySearchEngine/DiscoverySearchEngine/JsonExpectedSchema', 'DiscoverySearchEngine/DiscoverySearchEngine/JsonSchema4'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./JsonExpectedSchema'), require('./JsonSchema4'));
  } else {
    // Browser globals (root is window)
    if (!root.DiscoverySearchEngine) {
      root.DiscoverySearchEngine = {};
    }
    root.DiscoverySearchEngine.SwaggerResponse = factory(root.DiscoverySearchEngine.ApiClient, root.DiscoverySearchEngine.JsonExpectedSchema, root.DiscoverySearchEngine.JsonSchema4);
  }
}(this, function(ApiClient, JsonExpectedSchema, JsonSchema4) {
  'use strict';




  /**
   * The SwaggerResponse model module.
   * @module DiscoverySearchEngine/DiscoverySearchEngine/SwaggerResponse
   * @version v1
   */

  /**
   * Constructs a new <code>SwaggerResponse</code>.
   * The Swagger response.
   * @alias module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerResponse
   * @class
   */
  var exports = function() {
    var _this = this;






  };

  /**
   * Constructs a <code>SwaggerResponse</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerResponse} obj Optional instance to populate.
   * @return {module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerResponse} The populated <code>SwaggerResponse</code> instance.
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
      if (data.hasOwnProperty('headers')) {
        obj['headers'] = ApiClient.convertToType(data['headers'], {'String': JsonSchema4});
      }
      if (data.hasOwnProperty('x-nullable')) {
        obj['x-nullable'] = ApiClient.convertToType(data['x-nullable'], 'Boolean');
      }
      if (data.hasOwnProperty('x-expectedSchemas')) {
        obj['x-expectedSchemas'] = ApiClient.convertToType(data['x-expectedSchemas'], [JsonExpectedSchema]);
      }
    }
    return obj;
  }

  /**
   * Gets or sets the response's description.
   * @member {String} description
   */
  exports.prototype['description'] = undefined;
  /**
   * Gets or sets the response schema.
   * @member {module:DiscoverySearchEngine/DiscoverySearchEngine/JsonSchema4} schema
   */
  exports.prototype['schema'] = undefined;
  /**
   * Gets or sets the headers.
   * @member {Object.<String, module:DiscoverySearchEngine/DiscoverySearchEngine/JsonSchema4>} headers
   */
  exports.prototype['headers'] = undefined;
  /**
   * Sets a value indicating whether the response can be null (use IsNullable() to get a parameter's nullability).
   * @member {Boolean} x-nullable
   */
  exports.prototype['x-nullable'] = undefined;
  /**
   * Gets or sets the expected child schemas of the base schema (can be used for generating enhanced typings/documentation).
   * @member {Array.<module:DiscoverySearchEngine/DiscoverySearchEngine/JsonExpectedSchema>} x-expectedSchemas
   */
  exports.prototype['x-expectedSchemas'] = undefined;



  return exports;
}));


