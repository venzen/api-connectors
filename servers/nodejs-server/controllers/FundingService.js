'use strict';

exports.funding.get = function(args, res, next) {
  /**
   * parameters expected in the args:
  * symbol (String)
  * filter (String)
  * columns (String)
  * count (BigDecimal)
  * start (BigDecimal)
  * reverse (Boolean)
  * startTime (date)
  * endTime (date)
  **/
    var examples = {};
  examples['application/json'] = [ {
  "symbol" : "aeiou",
  "fundingRateDaily" : 1.3579000000000001069366817318950779736042022705078125,
  "fundingInterval" : "2000-01-23T04:56:07.000+00:00",
  "timestamp" : "2000-01-23T04:56:07.000+00:00",
  "fundingRate" : 1.3579000000000001069366817318950779736042022705078125
} ];
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
}

