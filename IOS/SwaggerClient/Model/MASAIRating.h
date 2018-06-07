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





@protocol MASAIRating
@end

@interface MASAIRating : MASAIObject

/* Minimum rating [optional]
 */
@property(nonatomic) NSNumber* minRating;
/* Maximum rating [optional]
 */
@property(nonatomic) NSNumber* maxRating;

@end
