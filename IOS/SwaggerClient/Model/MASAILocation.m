#import "MASAILocation.h"

@implementation MASAILocation

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
  return [[JSONKeyMapper alloc] initWithModelToJSONDictionary:@{ @"minLatitude": @"minLatitude", @"minLongitude": @"minLongitude", @"maxLatitude": @"maxLatitude", @"maxLongitude": @"maxLongitude", @"countries": @"countries", @"cities": @"cities" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"minLatitude", @"minLongitude", @"maxLatitude", @"maxLongitude", @"countries", @"cities"];
  return [optionalProperties containsObject:propertyName];
}

@end
