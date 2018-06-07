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
    instance = new ServiceDiscovery.Data();
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

  describe('Data', function() {
    it('should create an instance of Data', function() {
      // uncomment below and update the code to test Data
      //var instane = new ServiceDiscovery.Data();
      //expect(instance).to.be.a(ServiceDiscovery.Data);
    });

    it('should have the property planConditions (base name: "planConditions")', function() {
      // uncomment below and update the code to test the property planConditions
      //var instane = new ServiceDiscovery.Data();
      //expect(instance).to.be();
    });

    it('should have the property swagger (base name: "swagger")', function() {
      // uncomment below and update the code to test the property swagger
      //var instane = new ServiceDiscovery.Data();
      //expect(instance).to.be();
    });

    it('should have the property properties (base name: "properties")', function() {
      // uncomment below and update the code to test the property properties
      //var instane = new ServiceDiscovery.Data();
      //expect(instance).to.be();
    });

    it('should have the property contact (base name: "contact")', function() {
      // uncomment below and update the code to test the property contact
      //var instane = new ServiceDiscovery.Data();
      //expect(instance).to.be();
    });

    it('should have the property maintainers (base name: "maintainers")', function() {
      // uncomment below and update the code to test the property maintainers
      //var instane = new ServiceDiscovery.Data();
      //expect(instance).to.be();
    });

    it('should have the property tags (base name: "tags")', function() {
      // uncomment below and update the code to test the property tags
      //var instane = new ServiceDiscovery.Data();
      //expect(instance).to.be();
    });

    it('should have the property integrationMode (base name: "integrationMode")', function() {
      // uncomment below and update the code to test the property integrationMode
      //var instane = new ServiceDiscovery.Data();
      //expect(instance).to.be();
    });

    it('should have the property levelOfService (base name: "levelOfService")', function() {
      // uncomment below and update the code to test the property levelOfService
      //var instane = new ServiceDiscovery.Data();
      //expect(instance).to.be();
    });

    it('should have the property name (base name: "name")', function() {
      // uncomment below and update the code to test the property name
      //var instane = new ServiceDiscovery.Data();
      //expect(instance).to.be();
    });

    it('should have the property description (base name: "description")', function() {
      // uncomment below and update the code to test the property description
      //var instane = new ServiceDiscovery.Data();
      //expect(instance).to.be();
    });

    it('should have the property image (base name: "image")', function() {
      // uncomment below and update the code to test the property image
      //var instane = new ServiceDiscovery.Data();
      //expect(instance).to.be();
    });

    it('should have the property baseURL (base name: "baseURL")', function() {
      // uncomment below and update the code to test the property baseURL
      //var instane = new ServiceDiscovery.Data();
      //expect(instance).to.be();
    });

    it('should have the property humanURL (base name: "humanURL")', function() {
      // uncomment below and update the code to test the property humanURL
      //var instane = new ServiceDiscovery.Data();
      //expect(instance).to.be();
    });

    it('should have the property appName (base name: "appName")', function() {
      // uncomment below and update the code to test the property appName
      //var instane = new ServiceDiscovery.Data();
      //expect(instance).to.be();
    });

    it('should have the property packageName (base name: "packageName")', function() {
      // uncomment below and update the code to test the property packageName
      //var instane = new ServiceDiscovery.Data();
      //expect(instance).to.be();
    });

    it('should have the property deeplinkURL (base name: "deeplinkURL")', function() {
      // uncomment below and update the code to test the property deeplinkURL
      //var instane = new ServiceDiscovery.Data();
      //expect(instance).to.be();
    });

    it('should have the property planConditionsUrl (base name: "planConditionsUrl")', function() {
      // uncomment below and update the code to test the property planConditionsUrl
      //var instane = new ServiceDiscovery.Data();
      //expect(instance).to.be();
    });

    it('should have the property updatedAt (base name: "updatedAt")', function() {
      // uncomment below and update the code to test the property updatedAt
      //var instane = new ServiceDiscovery.Data();
      //expect(instance).to.be();
    });

    it('should have the property signatureKey (base name: "signatureKey")', function() {
      // uncomment below and update the code to test the property signatureKey
      //var instane = new ServiceDiscovery.Data();
      //expect(instance).to.be();
    });

    it('should have the property authoritative (base name: "authoritative")', function() {
      // uncomment below and update the code to test the property authoritative
      //var instane = new ServiceDiscovery.Data();
      //expect(instance).to.be();
    });

    it('should have the property id (base name: "id")', function() {
      // uncomment below and update the code to test the property id
      //var instane = new ServiceDiscovery.Data();
      //expect(instance).to.be();
    });

  });

}));
