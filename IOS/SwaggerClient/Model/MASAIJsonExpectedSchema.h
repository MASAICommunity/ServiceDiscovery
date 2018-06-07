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


#import "MASAIJsonSchema4.h"
@protocol MASAIJsonSchema4;
@class MASAIJsonSchema4;



@protocol MASAIJsonExpectedSchema
@end

@interface MASAIJsonExpectedSchema : MASAIObject

/* Gets or sets the description. [optional]
 */
@property(nonatomic) NSString* _description;
/* Gets or sets the schema. [optional]
 */
@property(nonatomic) MASAIJsonSchema4* schema;

@end
