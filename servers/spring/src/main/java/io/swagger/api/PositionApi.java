package io.swagger.api;

import io.swagger.model.Position;
import io.swagger.model.Error;
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

@Api(value = "position", description = "the position API")
public interface PositionApi {

    @ApiOperation(value = "Get your positions.", notes = "See <a href=\"http://www.onixs.biz/fix-dictionary/5.0.SP2/msgType_AP_6580.html\">the FIX Spec</a> for explanations of these fields.", response = Position.class, responseContainer = "List", tags={ "Position", })
    @ApiResponses(value = { 
        @ApiResponse(code = 200, message = "Request was successful", response = Position.class),
        @ApiResponse(code = 400, message = "Parameter Error", response = Position.class),
        @ApiResponse(code = 401, message = "Unauthorized", response = Position.class),
        @ApiResponse(code = 404, message = "Not Found", response = Position.class) })
    @RequestMapping(value = "/position",
        produces = { "application/json", "application/xml", "text/xml", "application/javascript", "text/javascript" }, 
        consumes = { "application/json", "application/x-www-form-urlencoded" },
        method = RequestMethod.GET)
    ResponseEntity<List<Position>> positionGet(@ApiParam(value = "Table filter. For example, send {\"symbol\": \"XBT24H\"}.") @RequestParam(value = "filter", required = false) String filter,@ApiParam(value = "Which columns to fetch. For example, send [\"columnName\"].") @RequestParam(value = "columns", required = false) String columns,@ApiParam(value = "Number of rows to fetch.") @RequestParam(value = "count", required = false) BigDecimal count);


    @ApiOperation(value = "Enable isolated margin or cross margin per-position.", notes = "On Speculative (DPE-Enabled) contracts, users can switch isolate margin per-position. This function allows switching margin isolation (aka fixed margin) on and off.", response = Position.class, tags={ "Position", })
    @ApiResponses(value = { 
        @ApiResponse(code = 200, message = "Request was successful", response = Position.class),
        @ApiResponse(code = 400, message = "Parameter Error", response = Position.class),
        @ApiResponse(code = 401, message = "Unauthorized", response = Position.class),
        @ApiResponse(code = 404, message = "Not Found", response = Position.class) })
    @RequestMapping(value = "/position/isolate",
        produces = { "application/json", "application/xml", "text/xml", "application/javascript", "text/javascript" }, 
        consumes = { "application/json", "application/x-www-form-urlencoded" },
        method = RequestMethod.POST)
    ResponseEntity<Position> positionIsolateMargin(@ApiParam(value = "Position symbol to isolate.", required=true ) @RequestPart(value="symbol", required=true)  String symbol,@ApiParam(value = "True for isolated margin, false for cross margin." , defaultValue="true") @RequestPart(value="enabled", required=false)  Boolean enabled);


    @ApiOperation(value = "Transfer equity in or out of a position.", notes = "When margin is isolated on a position, use this function to add or remove margin from the position. Note that you cannot remove margin below the initial margin threshold.", response = Position.class, tags={ "Position", })
    @ApiResponses(value = { 
        @ApiResponse(code = 200, message = "Request was successful", response = Position.class),
        @ApiResponse(code = 400, message = "Parameter Error", response = Position.class),
        @ApiResponse(code = 401, message = "Unauthorized", response = Position.class),
        @ApiResponse(code = 404, message = "Not Found", response = Position.class) })
    @RequestMapping(value = "/position/transferMargin",
        produces = { "application/json", "application/xml", "text/xml", "application/javascript", "text/javascript" }, 
        consumes = { "application/json", "application/x-www-form-urlencoded" },
        method = RequestMethod.POST)
    ResponseEntity<Position> positionTransferIsolatedMargin(@ApiParam(value = "Symbol of position to isolate.", required=true ) @RequestPart(value="symbol", required=true)  String symbol,@ApiParam(value = "Amount to transfer, in Satoshis. May be negative.", required=true ) @RequestPart(value="amount", required=true)  BigDecimal amount);


    @ApiOperation(value = "Choose leverage for a position.", notes = "On Speculative (DPE-Enabled) contracts, users can choose an isolated leverage. This will automatically enable isolated margin.", response = Position.class, tags={ "Position", })
    @ApiResponses(value = { 
        @ApiResponse(code = 200, message = "Request was successful", response = Position.class),
        @ApiResponse(code = 400, message = "Parameter Error", response = Position.class),
        @ApiResponse(code = 401, message = "Unauthorized", response = Position.class),
        @ApiResponse(code = 404, message = "Not Found", response = Position.class) })
    @RequestMapping(value = "/position/leverage",
        produces = { "application/json", "application/xml", "text/xml", "application/javascript", "text/javascript" }, 
        consumes = { "application/json", "application/x-www-form-urlencoded" },
        method = RequestMethod.POST)
    ResponseEntity<Position> positionUpdateLeverage(@ApiParam(value = "Symbol of position to adjust.", required=true ) @RequestPart(value="symbol", required=true)  String symbol,@ApiParam(value = "Leverage value. Send a number between 0.01 and 100 to enable isolated margin with a fixed leverage. Send 0 to enable cross margin.", required=true ) @RequestPart(value="leverage", required=true)  Double leverage);

}
