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
    define(['DiscoverySearchEngine/ApiClient', 'DiscoverySearchEngine/DiscoverySearchEngine/JsonSchema4', 'DiscoverySearchEngine/DiscoverySearchEngine/SwaggerDocumentPaths', 'DiscoverySearchEngine/DiscoverySearchEngine/SwaggerExternalDocumentation', 'DiscoverySearchEngine/DiscoverySearchEngine/SwaggerInfo', 'DiscoverySearchEngine/DiscoverySearchEngine/SwaggerParameter', 'DiscoverySearchEngine/DiscoverySearchEngine/SwaggerResponse', 'DiscoverySearchEngine/DiscoverySearchEngine/SwaggerSecurityScheme', 'DiscoverySearchEngine/DiscoverySearchEngine/SwaggerTag'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./JsonSchema4'), require('./SwaggerDocumentPaths'), require('./SwaggerExternalDocumentation'), require('./SwaggerInfo'), require('./SwaggerParameter'), require('./SwaggerResponse'), require('./SwaggerSecurityScheme'), require('./SwaggerTag'));
  } else {
    // Browser globals (root is window)
    if (!root.DiscoverySearchEngine) {
      root.DiscoverySearchEngine = {};
    }
    root.DiscoverySearchEngine.SwaggerDocument = factory(root.DiscoverySearchEngine.ApiClient, root.DiscoverySearchEngine.JsonSchema4, root.DiscoverySearchEngine.SwaggerDocumentPaths, root.DiscoverySearchEngine.SwaggerExternalDocumentation, root.DiscoverySearchEngine.SwaggerInfo, root.DiscoverySearchEngine.SwaggerParameter, root.DiscoverySearchEngine.SwaggerResponse, root.DiscoverySearchEngine.SwaggerSecurityScheme, root.DiscoverySearchEngine.SwaggerTag);
  }
}(this, function(ApiClient, JsonSchema4, SwaggerDocumentPaths, SwaggerExternalDocumentation, SwaggerInfo, SwaggerParameter, SwaggerResponse, SwaggerSecurityScheme, SwaggerTag) {
  'use strict';




  /**
   * The SwaggerDocument model module.
   * @module DiscoverySearchEngine/DiscoverySearchEngine/SwaggerDocument
   * @version v1
   */

  /**
   * Constructs a new <code>SwaggerDocument</code>.
   * Describes a JSON web service.
   * @alias module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerDocument
   * @class
   */
  var exports = function() {
    var _this = this;

















  };

  /**
   * Constructs a <code>SwaggerDocument</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerDocument} obj Optional instance to populate.
   * @return {module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerDocument} The populated <code>SwaggerDocument</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('x-generator')) {
        obj['x-generator'] = ApiClient.convertToType(data['x-generator'], 'String');
      }
      if (data.hasOwnProperty('swagger')) {
        obj['swagger'] = ApiClient.convertToType(data['swagger'], 'String');
      }
      if (data.hasOwnProperty('info')) {
        obj['info'] = SwaggerInfo.constructFromObject(data['info']);
      }
      if (data.hasOwnProperty('host')) {
        obj['host'] = ApiClient.convertToType(data['host'], 'String');
      }
      if (data.hasOwnProperty('basePath')) {
        obj['basePath'] = ApiClient.convertToType(data['basePath'], 'String');
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
      if (data.hasOwnProperty('paths')) {
        obj['paths'] = ApiClient.convertToType(data['paths'], {'String': SwaggerDocumentPaths});
      }
      if (data.hasOwnProperty('definitions')) {
        obj['definitions'] = ApiClient.convertToType(data['definitions'], {'String': JsonSchema4});
      }
      if (data.hasOwnProperty('parameters')) {
        obj['parameters'] = ApiClient.convertToType(data['parameters'], {'String': SwaggerParameter});
      }
      if (data.hasOwnProperty('responses')) {
        obj['responses'] = ApiClient.convertToType(data['responses'], {'String': SwaggerResponse});
      }
      if (data.hasOwnProperty('securityDefinitions')) {
        obj['securityDefinitions'] = ApiClient.convertToType(data['securityDefinitions'], {'String': SwaggerSecurityScheme});
      }
      if (data.hasOwnProperty('security')) {
        obj['security'] = ApiClient.convertToType(data['security'], [{'String': ['String']}]);
      }
      if (data.hasOwnProperty('tags')) {
        obj['tags'] = ApiClient.convertToType(data['tags'], [SwaggerTag]);
      }
      if (data.hasOwnProperty('externalDocs')) {
        obj['externalDocs'] = SwaggerExternalDocumentation.constructFromObject(data['externalDocs']);
      }
    }
    return obj;
  }

  /**
   * Gets or sets the Swagger generator information.
   * @member {String} x-generator
   */
  exports.prototype['x-generator'] = undefined;
  /**
   * Gets or sets the Swagger specification version being used.
   * @member {String} swagger
   */
  exports.prototype['swagger'] = undefined;
  /**
   * Gets or sets the metadata about the API.
   * @member {module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerInfo} info
   */
  exports.prototype['info'] = undefined;
  /**
   * Gets or sets the host (name or ip) serving the API.
   * @member {String} host
   */
  exports.prototype['host'] = undefined;
  /**
   * Gets or sets the base path on which the API is served, which is relative to the {NSwag.SwaggerDocument.Host}.
   * @member {String} basePath
   */
  exports.prototype['basePath'] = undefined;
  /**
   * Gets or sets the schemes.
   * @member {Array.<module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerDocument.SchemesEnum>} schemes
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
   * Gets or sets the operations.
   * @member {Object.<String, module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerDocumentPaths>} paths
   */
  exports.prototype['paths'] = undefined;
  /**
   * Gets or sets the types.
   * @member {Object.<String, module:DiscoverySearchEngine/DiscoverySearchEngine/JsonSchema4>} definitions
   */
  exports.prototype['definitions'] = undefined;
  /**
   * Gets or sets the parameters which can be used for all operations.
   * @member {Object.<String, module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerParameter>} parameters
   */
  exports.prototype['parameters'] = undefined;
  /**
   * Gets or sets the responses which can be used for all operations.
   * @member {Object.<String, module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerResponse>} responses
   */
  exports.prototype['responses'] = undefined;
  /**
   * Gets or sets the security definitions.
   * @member {Object.<String, module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerSecurityScheme>} securityDefinitions
   */
  exports.prototype['securityDefinitions'] = undefined;
  /**
   * Gets or sets a security description.
   * @member {Array.<Object.<String, Array.<String>>>} security
   */
  exports.prototype['security'] = undefined;
  /**
   * Gets or sets the description.
   * @member {Array.<module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerTag>} tags
   */
  exports.prototype['tags'] = undefined;
  /**
   * Gets or sets the external documentation.
   * @member {module:DiscoverySearchEngine/DiscoverySearchEngine/SwaggerExternalDocumentation} externalDocs
   */
  exports.prototype['externalDocs'] = undefined;


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


