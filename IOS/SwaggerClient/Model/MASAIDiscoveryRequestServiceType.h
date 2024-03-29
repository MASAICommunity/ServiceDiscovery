#import <Foundation/Foundation.h>
#import "MASAIObject.h"

/**
* MASAI Service Discovery API
* No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
*
* OpenAPI spec version: v1
* 
*
* NOTE: This class is auto generated by the swagger code generator program.
* https://github.com/swagger-api/swagger-codegen.git
* Do not edit the class manually.
*/





@protocol MASAIDiscoveryRequestServiceType
@end

@interface MASAIDiscoveryRequestServiceType : MASAIObject


@property(nonatomic) NSString* discovery;

@property(nonatomic) NSString* booking;

@property(nonatomic) NSString* reschedule;

@property(nonatomic) NSString* info;

@property(nonatomic) NSString* all;

@end
