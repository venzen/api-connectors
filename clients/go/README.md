# Go API client for swagger

REST API for the BitMEX.com trading platform.<br><br><a href=\"/app/restAPI\">REST Documentation</a><br><a href=\"/app/wsAPI\">Websocket Documentation</a>

## Overview
This API client was generated by the [swagger-codegen](https://github.com/swagger-api/swagger-codegen) project.  By using the [swagger-spec](https://github.com/swagger-api/swagger-spec) from a remote server, you can easily generate an API client.

- API version: 1.2.0
- Package version: 1.0.0
- Build date: 2016-07-05T09:40:51.967-05:00
- Build package: class io.swagger.codegen.languages.GoClientCodegen

## Installation
Put the package under your project folder and add the following in import:
```
    "./swagger"
```

## Documentation for API Endpoints

All URIs are relative to *https://localhost/api/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AnnouncementApi* | [**AnnouncementGet**](docs/AnnouncementApi.md#announcementget) | **Get** /announcement | Get site announcements.
*AnnouncementApi* | [**AnnouncementGetUrgent**](docs/AnnouncementApi.md#announcementgeturgent) | **Get** /announcement/urgent | Get urgent (banner) announcements.
*ApiKeyApi* | [**ApiKeyDisable**](docs/ApiKeyApi.md#apikeydisable) | **Post** /apiKey/disable | Disable an API Key.
*ApiKeyApi* | [**ApiKeyEnable**](docs/ApiKeyApi.md#apikeyenable) | **Post** /apiKey/enable | Enable an API Key.
*ApiKeyApi* | [**ApiKeyGet**](docs/ApiKeyApi.md#apikeyget) | **Get** /apiKey | Get your API Keys.
*ApiKeyApi* | [**ApiKeyNew**](docs/ApiKeyApi.md#apikeynew) | **Post** /apiKey | Create a new API Key.
*ApiKeyApi* | [**ApiKeyRemove**](docs/ApiKeyApi.md#apikeyremove) | **Delete** /apiKey | Remove an API Key.
*ChatApi* | [**ChatGet**](docs/ChatApi.md#chatget) | **Get** /chat | Get chat messages.
*ChatApi* | [**ChatGetConnected**](docs/ChatApi.md#chatgetconnected) | **Get** /chat/connected | Get connected users.
*ChatApi* | [**ChatNew**](docs/ChatApi.md#chatnew) | **Post** /chat | Send a chat message.
*ExecutionApi* | [**ExecutionGet**](docs/ExecutionApi.md#executionget) | **Get** /execution | Get all raw executions for your account.
*ExecutionApi* | [**ExecutionGetTradeHistory**](docs/ExecutionApi.md#executiongettradehistory) | **Get** /execution/tradeHistory | Get all balance-affecting executions. This includes each trade, insurance charge, and settlement.
*FundingApi* | [**FundingGet**](docs/FundingApi.md#fundingget) | **Get** /funding | Get funding history.
*InstrumentApi* | [**InstrumentGet**](docs/InstrumentApi.md#instrumentget) | **Get** /instrument | Get instruments.
*InstrumentApi* | [**InstrumentGetActive**](docs/InstrumentApi.md#instrumentgetactive) | **Get** /instrument/active | Get all active instruments and instruments that have expired in &lt;24hrs.
*InstrumentApi* | [**InstrumentGetActiveAndIndices**](docs/InstrumentApi.md#instrumentgetactiveandindices) | **Get** /instrument/activeAndIndices | Helper method. Gets all active instruments and all indices. This is a join of the result of /indices and /active.
*InstrumentApi* | [**InstrumentGetActiveIntervals**](docs/InstrumentApi.md#instrumentgetactiveintervals) | **Get** /instrument/activeIntervals | Return all active contract series and interval pairs.
*InstrumentApi* | [**InstrumentGetIndices**](docs/InstrumentApi.md#instrumentgetindices) | **Get** /instrument/indices | Get all price indices.
*InsuranceApi* | [**InsuranceGet**](docs/InsuranceApi.md#insuranceget) | **Get** /insurance | Get insurance fund history.
*LeaderboardApi* | [**LeaderboardGet**](docs/LeaderboardApi.md#leaderboardget) | **Get** /leaderboard | Get current leaderboard.
*LiquidationApi* | [**LiquidationGet**](docs/LiquidationApi.md#liquidationget) | **Get** /liquidation | Get liquidation orders.
*OrderApi* | [**OrderAmend**](docs/OrderApi.md#orderamend) | **Put** /order | Amend the quantity or price of an open order.
*OrderApi* | [**OrderAmendBulk**](docs/OrderApi.md#orderamendbulk) | **Put** /order/bulk | Amend multiple orders.
*OrderApi* | [**OrderCancel**](docs/OrderApi.md#ordercancel) | **Delete** /order | Cancel order(s). Send multiple order IDs to cancel in bulk.
*OrderApi* | [**OrderCancelAll**](docs/OrderApi.md#ordercancelall) | **Delete** /order/all | Cancels all of your orders.
*OrderApi* | [**OrderCancelAllAfter**](docs/OrderApi.md#ordercancelallafter) | **Post** /order/cancelAllAfter | Automatically cancel all your orders after a specified timeout.
*OrderApi* | [**OrderClosePosition**](docs/OrderApi.md#ordercloseposition) | **Post** /order/closePosition | Close a position. [Deprecated, use POST /order with execInst: &#39;Close&#39;]
*OrderApi* | [**OrderGetOrders**](docs/OrderApi.md#ordergetorders) | **Get** /order | Get your orders.
*OrderApi* | [**OrderNew**](docs/OrderApi.md#ordernew) | **Post** /order | Create a new order.
*OrderApi* | [**OrderNewBulk**](docs/OrderApi.md#ordernewbulk) | **Post** /order/bulk | Create multiple new orders.
*OrderBookApi* | [**OrderBookGet**](docs/OrderBookApi.md#orderbookget) | **Get** /orderBook | Get current orderbook [deprecated, use /orderBook/L2].
*OrderBookApi* | [**OrderBookGetL2**](docs/OrderBookApi.md#orderbookgetl2) | **Get** /orderBook/L2 | Get current orderbook in vertical format.
*PositionApi* | [**PositionGet**](docs/PositionApi.md#positionget) | **Get** /position | Get your positions.
*PositionApi* | [**PositionIsolateMargin**](docs/PositionApi.md#positionisolatemargin) | **Post** /position/isolate | Enable isolated margin or cross margin per-position.
*PositionApi* | [**PositionTransferIsolatedMargin**](docs/PositionApi.md#positiontransferisolatedmargin) | **Post** /position/transferMargin | Transfer equity in or out of a position.
*PositionApi* | [**PositionUpdateLeverage**](docs/PositionApi.md#positionupdateleverage) | **Post** /position/leverage | Choose leverage for a position.
*QuoteApi* | [**QuoteGet**](docs/QuoteApi.md#quoteget) | **Get** /quote | Get Quotes.
*QuoteApi* | [**QuoteGetBucketed**](docs/QuoteApi.md#quotegetbucketed) | **Get** /quote/bucketed | Get previous quotes in time buckets.
*SchemaApi* | [**SchemaGet**](docs/SchemaApi.md#schemaget) | **Get** /schema | Get model schemata for data objects returned by this API.
*SchemaApi* | [**SchemaWebsocketHelp**](docs/SchemaApi.md#schemawebsockethelp) | **Get** /schema/websocketHelp | Returns help text &amp; subject list for websocket usage.
*SettlementApi* | [**SettlementGet**](docs/SettlementApi.md#settlementget) | **Get** /settlement | Get settlement history.
*StatsApi* | [**StatsGet**](docs/StatsApi.md#statsget) | **Get** /stats | Get exchange-wide and per-series turnover and volume statistics.
*StatsApi* | [**StatsHistory**](docs/StatsApi.md#statshistory) | **Get** /stats/history | Get historical exchange-wide and per-series turnover and volume statistics.
*TradeApi* | [**TradeGet**](docs/TradeApi.md#tradeget) | **Get** /trade | Get Trades.
*TradeApi* | [**TradeGetBucketed**](docs/TradeApi.md#tradegetbucketed) | **Get** /trade/bucketed | Get previous trades in time buckets.
*UserApi* | [**UserCancelWithdrawal**](docs/UserApi.md#usercancelwithdrawal) | **Post** /user/cancelWithdrawal | Cancel a withdrawal.
*UserApi* | [**UserCheckReferralCode**](docs/UserApi.md#usercheckreferralcode) | **Get** /user/checkReferralCode | Check if a referral code is valid.
*UserApi* | [**UserConfirmEmail**](docs/UserApi.md#userconfirmemail) | **Post** /user/confirmEmail | Confirm your email address with a token.
*UserApi* | [**UserConfirmEnableTFA**](docs/UserApi.md#userconfirmenabletfa) | **Post** /user/confirmEnableTFA | Confirm two-factor auth for this account. If using a Yubikey, simply send a token to this endpoint.
*UserApi* | [**UserConfirmPasswordReset**](docs/UserApi.md#userconfirmpasswordreset) | **Post** /user/confirmPasswordReset | Confirm a password reset.
*UserApi* | [**UserConfirmWithdrawal**](docs/UserApi.md#userconfirmwithdrawal) | **Post** /user/confirmWithdrawal | Confirm a withdrawal.
*UserApi* | [**UserDisableTFA**](docs/UserApi.md#userdisabletfa) | **Post** /user/disableTFA | Disable two-factor auth for this account.
*UserApi* | [**UserGet**](docs/UserApi.md#userget) | **Get** /user | Get your user model.
*UserApi* | [**UserGetAffiliateStatus**](docs/UserApi.md#usergetaffiliatestatus) | **Get** /user/affiliateStatus | Get your current affiliate/referral status.
*UserApi* | [**UserGetCommission**](docs/UserApi.md#usergetcommission) | **Get** /user/commission | Get your account&#39;s commission status.
*UserApi* | [**UserGetDepositAddress**](docs/UserApi.md#usergetdepositaddress) | **Get** /user/depositAddress | Get a deposit address.
*UserApi* | [**UserGetMargin**](docs/UserApi.md#usergetmargin) | **Get** /user/margin | Get your account&#39;s margin status. Send a currency of \&quot;all\&quot; to receive an array of all supported currencies.
*UserApi* | [**UserGetWalletHistory**](docs/UserApi.md#usergetwallethistory) | **Get** /user/walletHistory | Get a history of all of your wallet transactions (deposits and withdrawals).
*UserApi* | [**UserLogin**](docs/UserApi.md#userlogin) | **Post** /user/login | Log in to BitMEX.
*UserApi* | [**UserLogout**](docs/UserApi.md#userlogout) | **Post** /user/logout | Log out of BitMEX.
*UserApi* | [**UserLogoutAll**](docs/UserApi.md#userlogoutall) | **Post** /user/logoutAll | Log all systems out of BitMEX. This will revoke all of your account&#39;s access tokens, logging you out on all devices.
*UserApi* | [**UserNew**](docs/UserApi.md#usernew) | **Post** /user | Register a new user.
*UserApi* | [**UserRequestEnableTFA**](docs/UserApi.md#userrequestenabletfa) | **Post** /user/requestEnableTFA | Get Google Authenticator secret key for setting up two-factor auth. Fails if already enabled. Use /confirmEnableTFA for Yubikeys.
*UserApi* | [**UserRequestPasswordReset**](docs/UserApi.md#userrequestpasswordreset) | **Post** /user/requestPasswordReset | Request a password reset.
*UserApi* | [**UserRequestWithdrawal**](docs/UserApi.md#userrequestwithdrawal) | **Post** /user/requestWithdrawal | Request a withdrawal to an external wallet.
*UserApi* | [**UserSavePreferences**](docs/UserApi.md#usersavepreferences) | **Post** /user/preferences | Save user preferences.
*UserApi* | [**UserSendVerificationEmail**](docs/UserApi.md#usersendverificationemail) | **Post** /user/resendVerificationEmail | Re-send verification email.
*UserApi* | [**UserUpdate**](docs/UserApi.md#userupdate) | **Put** /user | Update your password, name, and other attributes.


## Documentation For Models

 - [AccessToken](docs/AccessToken.md)
 - [Affiliate](docs/Affiliate.md)
 - [Announcement](docs/Announcement.md)
 - [ApiKey](docs/ApiKey.md)
 - [Chat](docs/Chat.md)
 - [ConnectedUsers](docs/ConnectedUsers.md)
 - [Execution](docs/Execution.md)
 - [Funding](docs/Funding.md)
 - [InlineResponse200](docs/InlineResponse200.md)
 - [Instrument](docs/Instrument.md)
 - [InstrumentInterval](docs/InstrumentInterval.md)
 - [Insurance](docs/Insurance.md)
 - [Leaderboard](docs/Leaderboard.md)
 - [Liquidation](docs/Liquidation.md)
 - [Margin](docs/Margin.md)
 - [ModelError](docs/ModelError.md)
 - [Order](docs/Order.md)
 - [OrderBook](docs/OrderBook.md)
 - [OrderBookL2](docs/OrderBookL2.md)
 - [Position](docs/Position.md)
 - [Quote](docs/Quote.md)
 - [Settlement](docs/Settlement.md)
 - [Stats](docs/Stats.md)
 - [StatsHistory](docs/StatsHistory.md)
 - [Trade](docs/Trade.md)
 - [TradeBin](docs/TradeBin.md)
 - [Transaction](docs/Transaction.md)
 - [User](docs/User.md)
 - [UserCommission](docs/UserCommission.md)
 - [UserPreferences](docs/UserPreferences.md)


## Documentation For Authorization

 All endpoints do not require authorization.


## Author

support@bitmex.com

