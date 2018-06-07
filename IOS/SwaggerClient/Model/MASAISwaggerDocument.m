#import "MASAISwaggerDocument.h"

@implementation MASAISwaggerDocument

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
  return [[JSONKeyMapper alloc] initWithModelToJSONDictionary:@{ @"xGenerator": @"x-generator", @"swagger": @"swagger", @"info": @"info", @"host": @"host", @"basePath": @"basePath", @"schemes": @"schemes", @"consumes": @"consumes", @"produces": @"produces", @"paths": @"paths", @"definitions": @"definitions", @"parameters": @"parameters", @"responses": @"responses", @"securityDefinitions": @"securityDefinitions", @"security": @"security", @"tags": @"tags", @"externalDocs": @"externalDocs" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"xGenerator", @"swagger", @"info", @"host", @"basePath", @"schemes", @"consumes", @"produces", @"paths", @"definitions", @"parameters", @"responses", @"securityDefinitions", @"security", @"tags", @"externalDocs"];
  return [optionalProperties containsObject:propertyName];
}

@end
