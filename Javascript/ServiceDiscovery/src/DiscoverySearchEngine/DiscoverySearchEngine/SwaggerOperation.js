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
    define(['DiscoverySearchEngine/ApiClient', 'DiscoverySearchEngine/DiscoverySearchEngine/SwaggerExternalDocumentation', 'DiscoverySearchEngine/DiscoverySearchEngine/SwaggerParameter', 'DiscoverySearchEngine/DiscoverySearchEngine/SwaggerResponse'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./SwaggerExternalDocumentation'), require('./SwaggerParameter'), require('./SwaggerResponse'));
  } else {
    // Browser globals (root is window)
    if (!root.DiscoverySearchEngine) {
      root.DiscoverySearchEngine = {};
    }
    root.DiscoverySearchEngine.SwaggerOperation = factory(root.DiscoverySearchEngine.ApiClient, root.DiscoverySearchEngine.SwaggerExternalDocumentation, root.DiscoverySearchEngine.SwaggerParameter, root.DiscoverySearchEngine.SwaggerResponse);
  }
}(this, function(ApiClient, SwaggerExternalDocumentation, SwaggerParameter, SwaggerResponse) {
  'use strict';




  /**
   * The SwaggerOperation model module.
   * @module DiscoverySearchEngine/DiscoverySearchEngine/SwaggerOperation
   * @version v1
   */

  /**
   * Constructs a new <code>SwaggerOperation</code>.
   * Describes a JSON web service operation.
   * @alias module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerOperation
   * @class
   * @param responses {Object.<String, module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerResponse>} Gets or sets the HTTP Status Code/Response pairs.
   */
  var exports = function(responses) {
    var _this = this;










    _this['responses'] = responses;


  };

  /**
   * Constructs a <code>SwaggerOperation</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerOperation} obj Optional instance to populate.
   * @return {module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerOperation} The populated <code>SwaggerOperation</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('tags')) {
        obj['tags'] = ApiClient.convertToType(data['tags'], ['String']);
      }
      if (data.hasOwnProperty('summary')) {
        obj['summary'] = ApiClient.convertToType(data['summary'], 'String');
      }
      if (data.hasOwnProperty('description')) {
        obj['description'] = ApiClient.convertToType(data['description'], 'String');
      }
      if (data.hasOwnProperty('externalDocs')) {
        obj['externalDocs'] = SwaggerExternalDocumentation.constructFromObject(data['externalDocs']);
      }
      if (data.hasOwnProperty('operationId')) {
        obj['operationId'] = ApiClient.convertToType(data['operationId'], 'String');
      }
      if (data.hasOwnProperty('schemes')) {
        obj['schemes'] = ApiClient.convertToType(data['schemes'], ['String']);
      }
      if (data.hasOwnProperty('consumes')) {
        obj['consumes'] = ApiClient.convertToType(data['consumes'], ['String']);
      }
      if (data.hasOwnProperty('produces')) {
        obj['produces'] = ApiClient.convertToType(data['produces'], ['String']);
      }
      if (data.hasOwnProperty('parameters')) {
        obj['parameters'] = ApiClient.convertToType(data['parameters'], [SwaggerParameter]);
      }
      if (data.hasOwnProperty('responses')) {
        obj['responses'] = ApiClient.convertToType(data['responses'], {'String': SwaggerResponse});
      }
      if (data.hasOwnProperty('deprecated')) {
        obj['deprecated'] = ApiClient.convertToType(data['deprecated'], 'Boolean');
      }
      if (data.hasOwnProperty('security')) {
        obj['security'] = ApiClient.convertToType(data['security'], [{'String': ['String']}]);
      }
    }
    return obj;
  }

  /**
   * Gets or sets the tags.
   * @member {Array.<String>} tags
   */
  exports.prototype['tags'] = undefined;
  /**
   * Gets or sets the summary of the operation.
   * @member {String} summary
   */
  exports.prototype['summary'] = undefined;
  /**
   * Gets or sets the long description of the operation.
   * @member {String} description
   */
  exports.prototype['description'] = undefined;
  /**
   * Gets or sets the external documentation.
   * @member {module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerExternalDocumentation} externalDocs
   */
  exports.prototype['externalDocs'] = undefined;
  /**
   * Gets or sets the operation ID (unique name).
   * @member {String} operationId
   */
  exports.prototype['operationId'] = undefined;
  /**
   * Gets or sets the schemes.
   * @member {Array.<module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerOperation.SchemesEnum>} schemes
   */
  exports.prototype['schemes'] = undefined;
  /**
   * Gets or sets a list of MIME types the operation can consume.
   * @member {Array.<String>} consumes
   */
  exports.prototype['consumes'] = undefined;
  /**
   * Gets or sets a list of MIME types the operation can produce.
   * @member {Array.<String>} produces
   */
  exports.prototype['produces'] = undefined;
  /**
   * Gets or sets the parameters.
   * @member {Array.<module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerParameter>} parameters
   */
  exports.prototype['parameters'] = undefined;
  /**
   * Gets or sets the HTTP Status Code/Response pairs.
   * @member {Object.<String, module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerResponse>} responses
   */
  exports.prototype['responses'] = undefined;
  /**
   * Gets or sets a value indicating whether the operation is deprecated.
   * @member {Boolean} deprecated
   */
  exports.prototype['deprecated'] = undefined;
  /**
   * Gets or sets a security description.
   * @member {Array.<Object.<String, Array.<String>>>} security
   */
  exports.prototype['security'] = undefined;


  /**
   * Allowed values for the <code>schemes</code> property.
   * @enum {String}
   * @readonly
   */
  exports.SchemesEnum = {
    /**
     * value: "undefined"
     * @const
     */
    "undefined": "undefined",
    /**
     * value: "http"
     * @const
     */
    "http": "http",
    /**
     * value: "https"
     * @const
     */
    "https": "https",
    /**
     * value: "ws"
     * @const
     */
    "ws": "ws",
    /**
     * value: "wss"
     * @const
     */
    "wss": "wss"  };


  return exports;
}));


