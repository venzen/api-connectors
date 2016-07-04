#import <Foundation/Foundation.h>
#import "SWGError.h"
#import "SWGQuote.h"
#import "SWGObject.h"
#import "SWGApiClient.h"


/**
 * NOTE: This class is auto generated by the swagger code generator program. 
 * https://github.com/swagger-api/swagger-codegen 
 * Do not edit the class manually.
 */

@interface SWGQuoteApi: NSObject

@property(nonatomic, assign)SWGApiClient *apiClient;

-(instancetype) initWithApiClient:(SWGApiClient *)apiClient;
-(void) addHeader:(NSString*)value forKey:(NSString*)key;
-(unsigned long) requestQueueSize;
+(SWGQuoteApi*) apiWithHeader:(NSString*)headerValue key:(NSString*)key;
+(SWGQuoteApi*) sharedAPI;
///
///
/// Get Quotes.
/// 
///
/// @param symbol Instrument symbol. Send a bare series (e.g. XBU) to get data for the nearest expiring contract in that series.\n\nYou can also send a timeframe, e.g. `XBU:monthly`. Timeframes are `daily`, `weekly`, `monthly`, `quarterly`, and `biquarterly`.
/// @param filter Generic table filter. Send JSON key/value pairs, such as `{\&quot;key\&quot;: \&quot;value\&quot;}`. You can key on individual fields, and do more advanced querying on timestamps. See the [Timestamp Docs](https://www.bitmex.com/app/restAPI#timestamp-filters) for more details.
/// @param columns Array of column names to fetch. If omitted, will return all columns.\n\nNote that this method will always return item keys, even when not specified, so you may receive more columns that you expect.
/// @param count Number of results to fetch.
/// @param start Starting point for results.
/// @param reverse If true, will sort results newest first.
/// @param startTime Starting date filter for results.
/// @param endTime Ending date filter for results.
/// 
///
/// @return NSArray<SWGQuote>*
-(NSNumber*) quoteGetWithCompletionBlock :(NSString*) symbol 
     filter:(NSString*) filter 
     columns:(NSString*) columns 
     count:(NSNumber*) count 
     start:(NSNumber*) start 
     reverse:(NSNumber*) reverse 
     startTime:(NSDate*) startTime 
     endTime:(NSDate*) endTime 
    
    completionHandler: (void (^)(NSArray<SWGQuote>* output, NSError* error))completionBlock;
    


///
///
/// Get previous quotes in time buckets.
/// 
///
/// @param binSize Time interval to bucket by. Available options: [&#39;1m&#39;, &#39;5m&#39;, &#39;1h&#39;, &#39;1d&#39;].
/// @param symbol Instrument symbol. Send a bare series (e.g. XBU) to get data for the nearest expiring contract in that series.\n\nYou can also send a timeframe, e.g. `XBU:monthly`. Timeframes are `daily`, `weekly`, `monthly`, `quarterly`, and `biquarterly`.
/// @param filter Generic table filter. Send JSON key/value pairs, such as `{\&quot;key\&quot;: \&quot;value\&quot;}`. You can key on individual fields, and do more advanced querying on timestamps. See the [Timestamp Docs](https://www.bitmex.com/app/restAPI#timestamp-filters) for more details.
/// @param columns Array of column names to fetch. If omitted, will return all columns.\n\nNote that this method will always return item keys, even when not specified, so you may receive more columns that you expect.
/// @param count Number of results to fetch.
/// @param start Starting point for results.
/// @param reverse If true, will sort results newest first.
/// @param startTime Starting date filter for results.
/// @param endTime Ending date filter for results.
/// 
///
/// @return NSArray<SWGQuote>*
-(NSNumber*) quoteGetBucketedWithCompletionBlock :(NSString*) binSize 
     symbol:(NSString*) symbol 
     filter:(NSString*) filter 
     columns:(NSString*) columns 
     count:(NSNumber*) count 
     start:(NSNumber*) start 
     reverse:(NSNumber*) reverse 
     startTime:(NSDate*) startTime 
     endTime:(NSDate*) endTime 
    
    completionHandler: (void (^)(NSArray<SWGQuote>* output, NSError* error))completionBlock;
    



@end
