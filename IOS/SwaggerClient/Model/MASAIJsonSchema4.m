#import "MASAIJsonSchema4.h"

@implementation MASAIJsonSchema4

- (instancetype)init {
  self = [super init];
  if (self) {
    // initialize property's default value, if any
    
  }
  return self;
}


/**
 * Maps json key to property name.
 * This method is used by `JSONModel`.
 */
+ (JSONKeyMapper *)keyMapper {
  return [[JSONKeyMapper alloc] initWithModelToJSONDictionary:@{ @"schema": @"$schema", @"_id": @"id", @"title": @"title", @"type": @"type", @"discriminator": @"discriminator", @"_description": @"description", @"schemaReferencePath": @"schemaReferencePath", @"format": @"format", @"_default": @"default", @"multipleOf": @"multipleOf", @"maximum": @"maximum", @"exclusiveMaximum": @"exclusiveMaximum", @"minimum": @"minimum", @"exclusiveMinimum": @"exclusiveMinimum", @"maxLength": @"maxLength", @"minLength": @"minLength", @"pattern": @"pattern", @"maxItems": @"maxItems", @"minItems": @"minItems", @"uniqueItems": @"uniqueItems", @"maxProperties": @"maxProperties", @"minProperties": @"minProperties", @"xml": @"xml", @"not": @"not", @"additionalItems": @"additionalItems", @"additionalProperties": @"additionalProperties", @"items": @"items", @"required": @"required", @"properties": @"properties", @"patternProperties": @"patternProperties", @"definitions": @"definitions", @"xEnumNames": @"x-enumNames", @"_enum": @"enum", @"allOf": @"allOf", @"anyOf": @"anyOf", @"oneOf": @"oneOf" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"schema", @"_id", @"title", @"type", @"discriminator", @"_description", @"schemaReferencePath", @"format", @"_default", @"multipleOf", @"maximum", @"exclusiveMaximum", @"minimum", @"exclusiveMinimum", @"maxLength", @"minLength", @"pattern", @"maxItems", @"minItems", @"uniqueItems", @"maxProperties", @"minProperties", @"xml", @"not", @"additionalItems", @"additionalProperties", @"items", @"required", @"properties", @"patternProperties", @"definitions", @"xEnumNames", @"_enum", @"allOf", @"anyOf", @"oneOf"];
  return [optionalProperties containsObject:propertyName];
}

@end
