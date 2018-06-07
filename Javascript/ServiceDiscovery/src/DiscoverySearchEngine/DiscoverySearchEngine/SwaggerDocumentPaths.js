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
    define(['DiscoverySearchEngine/ApiClient', 'DiscoverySearchEngine/DiscoverySearchEngine/SwaggerOperation'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./SwaggerOperation'));
  } else {
    // Browser globals (root is window)
    if (!root.DiscoverySearchEngine) {
      root.DiscoverySearchEngine = {};
    }
    root.DiscoverySearchEngine.SwaggerDocumentPaths = factory(root.DiscoverySearchEngine.ApiClient, root.DiscoverySearchEngine.SwaggerOperation);
  }
}(this, function(ApiClient, SwaggerOperation) {
  'use strict';




  /**
   * The SwaggerDocumentPaths model module.
   * @module DiscoverySearchEngine/DiscoverySearchEngine/SwaggerDocumentPaths
   * @version v1
   */

  /**
   * Constructs a new <code>SwaggerDocumentPaths</code>.
   * @alias module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerDocumentPaths
   * @class
   */
  var exports = function() {
    var _this = this;









  };

  /**
   * Constructs a <code>SwaggerDocumentPaths</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerDocumentPaths} obj Optional instance to populate.
   * @return {module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerDocumentPaths} The populated <code>SwaggerDocumentPaths</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('undefined')) {
        obj['undefined'] = SwaggerOperation.constructFromObject(data['undefined']);
      }
      if (data.hasOwnProperty('get')) {
        obj['get'] = SwaggerOperation.constructFromObject(data['get']);
      }
      if (data.hasOwnProperty('post')) {
        obj['post'] = SwaggerOperation.constructFromObject(data['post']);
      }
      if (data.hasOwnProperty('put')) {
        obj['put'] = SwaggerOperation.constructFromObject(data['put']);
      }
      if (data.hasOwnProperty('delete')) {
        obj['delete'] = SwaggerOperation.constructFromObject(data['delete']);
      }
      if (data.hasOwnProperty('options')) {
        obj['options'] = SwaggerOperation.constructFromObject(data['options']);
      }
      if (data.hasOwnProperty('head')) {
        obj['head'] = SwaggerOperation.constructFromObject(data['head']);
      }
      if (data.hasOwnProperty('patch')) {
        obj['patch'] = SwaggerOperation.constructFromObject(data['patch']);
      }
    }
    return obj;
  }

  /**
   * @member {module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerOperation} undefined
   */
  exports.prototype['undefined'] = undefined;
  /**
   * @member {module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerOperation} get
   */
  exports.prototype['get'] = undefined;
  /**
   * @member {module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerOperation} post
   */
  exports.prototype['post'] = undefined;
  /**
   * @member {module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerOperation} put
   */
  exports.prototype['put'] = undefined;
  /**
   * @member {module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerOperation} delete
   */
  exports.prototype['delete'] = undefined;
  /**
   * @member {module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerOperation} options
   */
  exports.prototype['options'] = undefined;
  /**
   * @member {module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerOperation} head
   */
  exports.prototype['head'] = undefined;
  /**
   * @member {module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerOperation} patch
   */
  exports.prototype['patch'] = undefined;



  return exports;
}));


