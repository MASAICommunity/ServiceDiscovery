#import "MASAISwaggerOperation.h"

@implementation MASAISwaggerOperation

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
  return [[JSONKeyMapper alloc] initWithModelToJSONDictionary:@{ @"tags": @"tags", @"summary": @"summary", @"_description": @"description", @"externalDocs": @"externalDocs", @"operationId": @"operationId", @"schemes": @"schemes", @"consumes": @"consumes", @"produces": @"produces", @"parameters": @"parameters", @"responses": @"responses", @"deprecated": @"deprecated", @"security": @"security" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"tags", @"summary", @"_description", @"externalDocs", @"operationId", @"schemes", @"consumes", @"produces", @"parameters", @"deprecated", @"security"];
  return [optionalProperties containsObject:propertyName];
}

@end
