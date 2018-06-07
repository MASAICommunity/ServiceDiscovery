#import "MASAIData.h"

@implementation MASAIData

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
  return [[JSONKeyMapper alloc] initWithModelToJSONDictionary:@{ @"planConditions": @"planConditions", @"swagger": @"swagger", @"properties": @"properties", @"contact": @"contact", @"maintainers": @"maintainers", @"tags": @"tags", @"integrationMode": @"integrationMode", @"levelOfService": @"levelOfService", @"name": @"name", @"_description": @"description", @"image": @"image", @"baseURL": @"baseURL", @"humanURL": @"humanURL", @"appName": @"appName", @"packageName": @"packageName", @"deeplinkURL": @"deeplinkURL", @"planConditionsUrl": @"planConditionsUrl", @"updatedAt": @"updatedAt", @"signatureKey": @"signatureKey", @"authoritative": @"authoritative", @"_id": @"id" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"planConditions", @"swagger", @"properties", @"contact", @"maintainers", @"tags", @"integrationMode", @"levelOfService", @"name", @"_description", @"image", @"baseURL", @"humanURL", @"appName", @"packageName", @"deeplinkURL", @"planConditionsUrl", @"updatedAt", @"signatureKey", @"authoritative", @"_id"];
  return [optionalProperties containsObject:propertyName];
}

@end
