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


#import "MASAISwaggerContact.h"
#import "MASAISwaggerLicense.h"
@protocol MASAISwaggerContact;
@class MASAISwaggerContact;
@protocol MASAISwaggerLicense;
@class MASAISwaggerLicense;



@protocol MASAISwaggerInfo
@end

@interface MASAISwaggerInfo : MASAIObject

/* Gets or sets the title. 
 */
@property(nonatomic) NSString* title;
/* Gets or sets the description. [optional]
 */
@property(nonatomic) NSString* _description;
/* Gets or sets the terms of service. [optional]
 */
@property(nonatomic) NSString* termsOfService;
/* Gets or sets the contact information. [optional]
 */
@property(nonatomic) MASAISwaggerContact* contact;
/* Gets or sets the license information. [optional]
 */
@property(nonatomic) MASAISwaggerLicense* license;
/* Gets or sets the API version. 
 */
@property(nonatomic) NSString* version;

@end
