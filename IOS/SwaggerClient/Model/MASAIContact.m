#import "MASAIContact.h"

@implementation MASAIContact

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
  return [[JSONKeyMapper alloc] initWithModelToJSONDictionary:@{ @"fullName": @"fullName", @"email": @"email", @"url": @"url", @"organization": @"organization", @"address": @"address", @"telephone": @"telephone", @"twitter": @"twitter", @"github": @"github", @"photo": @"photo", @"vCard": @"vCard" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"fullName", @"email", @"url", @"organization", @"address", @"telephone", @"twitter", @"github", @"photo", @"vCard"];
  return [optionalProperties containsObject:propertyName];
}

@end
