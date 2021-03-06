package io.swagger.api;

import io.swagger.model.Error;
import io.swagger.model.Liquidation;
import org.joda.time.LocalDate;
import java.math.BigDecimal;

import io.swagger.annotations.*;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestHeader;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RequestPart;
import org.springframework.web.multipart.MultipartFile;

import java.util.List;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.SpringCodegen", date = "2016-07-05T09:41:19.947-05:00")

@Api(value = "liquidation", description = "the liquidation API")
public interface LiquidationApi {

    @ApiOperation(value = "Get liquidation orders.", notes = "", response = Liquidation.class, responseContainer = "List", tags={ "Liquidation", })
    @ApiResponses(value = { 
        @ApiResponse(code = 200, message = "Request was successful", response = Liquidation.class),
        @ApiResponse(code = 400, message = "Parameter Error", response = Liquidation.class),
        @ApiResponse(code = 401, message = "Unauthorized", response = Liquidation.class),
        @ApiResponse(code = 404, message = "Not Found", response = Liquidation.class) })
    @RequestMapping(value = "/liquidation",
        produces = { "application/json", "application/xml", "text/xml", "application/javascript", "text/javascript" }, 
        consumes = { "application/json", "application/x-www-form-urlencoded" },
        method = RequestMethod.GET)
    ResponseEntity<List<Liquidation>> liquidationGet(@ApiParam(value = "Instrument symbol. Send a bare series (e.g. XBU) to get data for the nearest expiring contract in that series.  You can also send a timeframe, e.g. `XBU:monthly`. Timeframes are `daily`, `weekly`, `monthly`, `quarterly`, and `biquarterly`.") @RequestParam(value = "symbol", required = false) String symbol,@ApiParam(value = "Generic table filter. Send JSON key/value pairs, such as `{\"key\": \"value\"}`. You can key on individual fields, and do more advanced querying on timestamps. See the [Timestamp Docs](https://www.bitmex.com/app/restAPI#timestamp-filters) for more details.") @RequestParam(value = "filter", required = false) String filter,@ApiParam(value = "Array of column names to fetch. If omitted, will return all columns.  Note that this method will always return item keys, even when not specified, so you may receive more columns that you expect.") @RequestParam(value = "columns", required = false) String columns,@ApiParam(value = "Number of results to fetch.", defaultValue = "100") @RequestParam(value = "count", required = false, defaultValue="100") BigDecimal count,@ApiParam(value = "Starting point for results.", defaultValue = "0") @RequestParam(value = "start", required = false, defaultValue="0") BigDecimal start,@ApiParam(value = "If true, will sort results newest first.", defaultValue = "false") @RequestParam(value = "reverse", required = false, defaultValue="false") Boolean reverse,@ApiParam(value = "Starting date filter for results.") @RequestParam(value = "startTime", required = false) LocalDate startTime,@ApiParam(value = "Ending date filter for results.") @RequestParam(value = "endTime", required = false) LocalDate endTime);

}
