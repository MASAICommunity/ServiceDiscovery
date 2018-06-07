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





@protocol MASAISwaggerContact
@end

@interface MASAISwaggerContact : MASAIObject

/* Gets or sets the name. [optional]
 */
@property(nonatomic) NSString* name;
/* Gets or sets the contact URL. [optional]
 */
@property(nonatomic) NSString* url;
/* Gets or sets the contact email. [optional]
 */
@property(nonatomic) NSString* email;

@end