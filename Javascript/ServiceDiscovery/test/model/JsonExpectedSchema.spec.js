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
    // AMD.
    define(['expect.js', '../../src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require('../../src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.ServiceDiscovery);
  }
}(this, function(expect, ServiceDiscovery) {
  'use strict';

  var instance;

  beforeEach(function() {
    instance = new ServiceDiscovery.JsonExpectedSchema();
  });

  var getProperty = function(object, getter, property) {
    // Use getter method if present; otherwise, get the property directly.
    if (typeof object[getter] === 'function')
      return object[getter]();
    else
      return object[property];
  }

  var setProperty = function(object, setter, property, value) {
    // Use setter method if present; otherwise, set the property directly.
    if (typeof object[setter] === 'function')
      object[setter](value);
    else
      object[property] = value;
  }

  describe('JsonExpectedSchema', function() {
    it('should create an instance of JsonExpectedSchema', function() {
      // uncomment below and update the code to test JsonExpectedSchema
      //var instane = new ServiceDiscovery.JsonExpectedSchema();
      //expect(instance).to.be.a(ServiceDiscovery.JsonExpectedSchema);
    });

    it('should have the property description (base name: "description")', function() {
      // uncomment below and update the code to test the property description
      //var instane = new ServiceDiscovery.JsonExpectedSchema();
      //expect(instance).to.be();
    });

    it('should have the property schema (base name: "schema")', function() {
      // uncomment below and update the code to test the property schema
      //var instane = new ServiceDiscovery.JsonExpectedSchema();
      //expect(instance).to.be();
    });

  });

}));