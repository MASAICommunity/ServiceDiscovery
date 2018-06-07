#import "MASAISwaggerDocumentPaths.h"

@implementation MASAISwaggerDocumentPaths

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
  return [[JSONKeyMapper alloc] initWithModelToJSONDictionary:@{ @"undefined": @"undefined", @"get": @"get", @"post": @"post", @"put": @"put", @"delete": @"delete", @"options": @"options", @"head": @"head", @"patch": @"patch" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"undefined", @"get", @"post", @"put", @"delete", @"options", @"head", @"patch"];
  return [optionalProperties containsObject:propertyName];
}

@end
