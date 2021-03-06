# UserApi

All URIs are relative to *https://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**userCancelWithdrawal**](UserApi.md#userCancelWithdrawal) | **POST** /user/cancelWithdrawal | Cancel a withdrawal.
[**userCheckReferralCode**](UserApi.md#userCheckReferralCode) | **GET** /user/checkReferralCode | Check if a referral code is valid.
[**userConfirmEmail**](UserApi.md#userConfirmEmail) | **POST** /user/confirmEmail | Confirm your email address with a token.
[**userConfirmEnableTFA**](UserApi.md#userConfirmEnableTFA) | **POST** /user/confirmEnableTFA | Confirm two-factor auth for this account. If using a Yubikey, simply send a token to this endpoint.
[**userConfirmPasswordReset**](UserApi.md#userConfirmPasswordReset) | **POST** /user/confirmPasswordReset | Confirm a password reset.
[**userConfirmWithdrawal**](UserApi.md#userConfirmWithdrawal) | **POST** /user/confirmWithdrawal | Confirm a withdrawal.
[**userDisableTFA**](UserApi.md#userDisableTFA) | **POST** /user/disableTFA | Disable two-factor auth for this account.
[**userGet**](UserApi.md#userGet) | **GET** /user | Get your user model.
[**userGetAffiliateStatus**](UserApi.md#userGetAffiliateStatus) | **GET** /user/affiliateStatus | Get your current affiliate/referral status.
[**userGetCommission**](UserApi.md#userGetCommission) | **GET** /user/commission | Get your account&#39;s commission status.
[**userGetDepositAddress**](UserApi.md#userGetDepositAddress) | **GET** /user/depositAddress | Get a deposit address.
[**userGetMargin**](UserApi.md#userGetMargin) | **GET** /user/margin | Get your account&#39;s margin status. Send a currency of \&quot;all\&quot; to receive an array of all supported currencies.
[**userGetWalletHistory**](UserApi.md#userGetWalletHistory) | **GET** /user/walletHistory | Get a history of all of your wallet transactions (deposits and withdrawals).
[**userLogin**](UserApi.md#userLogin) | **POST** /user/login | Log in to BitMEX.
[**userLogout**](UserApi.md#userLogout) | **POST** /user/logout | Log out of BitMEX.
[**userLogoutAll**](UserApi.md#userLogoutAll) | **POST** /user/logoutAll | Log all systems out of BitMEX. This will revoke all of your account&#39;s access tokens, logging you out on all devices.
[**userNew**](UserApi.md#userNew) | **POST** /user | Register a new user.
[**userRequestEnableTFA**](UserApi.md#userRequestEnableTFA) | **POST** /user/requestEnableTFA | Get Google Authenticator secret key for setting up two-factor auth. Fails if already enabled. Use /confirmEnableTFA for Yubikeys.
[**userRequestPasswordReset**](UserApi.md#userRequestPasswordReset) | **POST** /user/requestPasswordReset | Request a password reset.
[**userRequestWithdrawal**](UserApi.md#userRequestWithdrawal) | **POST** /user/requestWithdrawal | Request a withdrawal to an external wallet.
[**userSavePreferences**](UserApi.md#userSavePreferences) | **POST** /user/preferences | Save user preferences.
[**userSendVerificationEmail**](UserApi.md#userSendVerificationEmail) | **POST** /user/resendVerificationEmail | Re-send verification email.
[**userUpdate**](UserApi.md#userUpdate) | **PUT** /user | Update your password, name, and other attributes.


<a name="userCancelWithdrawal"></a>
# **userCancelWithdrawal**
> Transaction userCancelWithdrawal(token)

Cancel a withdrawal.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UserApi;


UserApi apiInstance = new UserApi();
String token = "token_example"; // String | 
try {
    Transaction result = apiInstance.userCancelWithdrawal(token);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UserApi#userCancelWithdrawal");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**|  |

### Return type

[**Transaction**](Transaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

<a name="userCheckReferralCode"></a>
# **userCheckReferralCode**
> Double userCheckReferralCode(referralCode)

Check if a referral code is valid.

If the code is valid, responds with the referral code&#39;s discount (e.g. &#x60;0.1&#x60; for 10%). Otherwise, will return a 404.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UserApi;


UserApi apiInstance = new UserApi();
String referralCode = "referralCode_example"; // String | 
try {
    Double result = apiInstance.userCheckReferralCode(referralCode);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UserApi#userCheckReferralCode");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **referralCode** | **String**|  | [optional]

### Return type

**Double**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

<a name="userConfirmEmail"></a>
# **userConfirmEmail**
> AccessToken userConfirmEmail(token)

Confirm your email address with a token.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UserApi;


UserApi apiInstance = new UserApi();
String token = "token_example"; // String | 
try {
    AccessToken result = apiInstance.userConfirmEmail(token);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UserApi#userConfirmEmail");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**|  |

### Return type

[**AccessToken**](AccessToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

<a name="userConfirmEnableTFA"></a>
# **userConfirmEnableTFA**
> Boolean userConfirmEnableTFA(token, type)

Confirm two-factor auth for this account. If using a Yubikey, simply send a token to this endpoint.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UserApi;


UserApi apiInstance = new UserApi();
String token = "token_example"; // String | Token from your selected TFA type.
String type = "type_example"; // String | Two-factor auth type. Supported types: 'GA' (Google Authenticator), 'Yubikey'
try {
    Boolean result = apiInstance.userConfirmEnableTFA(token, type);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UserApi#userConfirmEnableTFA");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| Token from your selected TFA type. |
 **type** | **String**| Two-factor auth type. Supported types: &#39;GA&#39; (Google Authenticator), &#39;Yubikey&#39; | [optional]

### Return type

**Boolean**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

<a name="userConfirmPasswordReset"></a>
# **userConfirmPasswordReset**
> Boolean userConfirmPasswordReset(token, newPassword)

Confirm a password reset.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UserApi;


UserApi apiInstance = new UserApi();
String token = "token_example"; // String | 
String newPassword = "newPassword_example"; // String | 
try {
    Boolean result = apiInstance.userConfirmPasswordReset(token, newPassword);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UserApi#userConfirmPasswordReset");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**|  |
 **newPassword** | **String**|  |

### Return type

**Boolean**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

<a name="userConfirmWithdrawal"></a>
# **userConfirmWithdrawal**
> Transaction userConfirmWithdrawal(token)

Confirm a withdrawal.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UserApi;


UserApi apiInstance = new UserApi();
String token = "token_example"; // String | 
try {
    Transaction result = apiInstance.userConfirmWithdrawal(token);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UserApi#userConfirmWithdrawal");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**|  |

### Return type

[**Transaction**](Transaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

<a name="userDisableTFA"></a>
# **userDisableTFA**
> Boolean userDisableTFA(token, type)

Disable two-factor auth for this account.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UserApi;


UserApi apiInstance = new UserApi();
String token = "token_example"; // String | Token from your selected TFA type.
String type = "type_example"; // String | Two-factor auth type. Supported types: 'GA' (Google Authenticator)
try {
    Boolean result = apiInstance.userDisableTFA(token, type);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UserApi#userDisableTFA");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| Token from your selected TFA type. |
 **type** | **String**| Two-factor auth type. Supported types: &#39;GA&#39; (Google Authenticator) | [optional]

### Return type

**Boolean**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

<a name="userGet"></a>
# **userGet**
> User userGet()

Get your user model.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UserApi;


UserApi apiInstance = new UserApi();
try {
    User result = apiInstance.userGet();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UserApi#userGet");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

<a name="userGetAffiliateStatus"></a>
# **userGetAffiliateStatus**
> List&lt;Affiliate&gt; userGetAffiliateStatus()

Get your current affiliate/referral status.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UserApi;


UserApi apiInstance = new UserApi();
try {
    List<Affiliate> result = apiInstance.userGetAffiliateStatus();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UserApi#userGetAffiliateStatus");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;Affiliate&gt;**](Affiliate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

<a name="userGetCommission"></a>
# **userGetCommission**
> List&lt;UserCommission&gt; userGetCommission()

Get your account&#39;s commission status.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UserApi;


UserApi apiInstance = new UserApi();
try {
    List<UserCommission> result = apiInstance.userGetCommission();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UserApi#userGetCommission");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;UserCommission&gt;**](UserCommission.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

<a name="userGetDepositAddress"></a>
# **userGetDepositAddress**
> String userGetDepositAddress(currency)

Get a deposit address.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UserApi;


UserApi apiInstance = new UserApi();
String currency = "XBt"; // String | 
try {
    String result = apiInstance.userGetDepositAddress(currency);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UserApi#userGetDepositAddress");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **String**|  | [optional] [default to XBt]

### Return type

**String**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

<a name="userGetMargin"></a>
# **userGetMargin**
> Margin userGetMargin(currency)

Get your account&#39;s margin status. Send a currency of \&quot;all\&quot; to receive an array of all supported currencies.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UserApi;


UserApi apiInstance = new UserApi();
String currency = "XBt"; // String | 
try {
    Margin result = apiInstance.userGetMargin(currency);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UserApi#userGetMargin");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **String**|  | [optional] [default to XBt]

### Return type

[**Margin**](Margin.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

<a name="userGetWalletHistory"></a>
# **userGetWalletHistory**
> List&lt;Transaction&gt; userGetWalletHistory(currency)

Get a history of all of your wallet transactions (deposits and withdrawals).

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UserApi;


UserApi apiInstance = new UserApi();
String currency = "XBt"; // String | 
try {
    List<Transaction> result = apiInstance.userGetWalletHistory(currency);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UserApi#userGetWalletHistory");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **String**|  | [optional] [default to XBt]

### Return type

[**List&lt;Transaction&gt;**](Transaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

<a name="userLogin"></a>
# **userLogin**
> AccessToken userLogin(email, password, token)

Log in to BitMEX.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UserApi;


UserApi apiInstance = new UserApi();
String email = "email_example"; // String | Your email address.
String password = "password_example"; // String | Your password.
String token = "token_example"; // String | OTP Token (YubiKey, Google Authenticator)
try {
    AccessToken result = apiInstance.userLogin(email, password, token);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UserApi#userLogin");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **String**| Your email address. |
 **password** | **String**| Your password. |
 **token** | **String**| OTP Token (YubiKey, Google Authenticator) | [optional]

### Return type

[**AccessToken**](AccessToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

<a name="userLogout"></a>
# **userLogout**
> userLogout()

Log out of BitMEX.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UserApi;


UserApi apiInstance = new UserApi();
try {
    apiInstance.userLogout();
} catch (ApiException e) {
    System.err.println("Exception when calling UserApi#userLogout");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

<a name="userLogoutAll"></a>
# **userLogoutAll**
> Double userLogoutAll()

Log all systems out of BitMEX. This will revoke all of your account&#39;s access tokens, logging you out on all devices.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UserApi;


UserApi apiInstance = new UserApi();
try {
    Double result = apiInstance.userLogoutAll();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UserApi#userLogoutAll");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Double**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

<a name="userNew"></a>
# **userNew**
> User userNew(email, password, country, username, firstname, lastname, acceptsTOS, referrerID, tfaType, tfaToken)

Register a new user.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UserApi;


UserApi apiInstance = new UserApi();
String email = "email_example"; // String | Your email address.
String password = "password_example"; // String | Your password.
String country = "country_example"; // String | Country of residence.
String username = "username_example"; // String | Desired username.
String firstname = "firstname_example"; // String | First name.
String lastname = "lastname_example"; // String | Last name.
String acceptsTOS = "acceptsTOS_example"; // String | Set to true to indicate acceptance of the Terms of Service (https://www.bitmex.com/terms).
String referrerID = "referrerID_example"; // String | Optional Referrer ID.
String tfaType = "tfaType_example"; // String | Optional Two-Factor Type. Accepted values: GA, Yubikey, Clef
String tfaToken = "tfaToken_example"; // String | Two-Factor Token.
try {
    User result = apiInstance.userNew(email, password, country, username, firstname, lastname, acceptsTOS, referrerID, tfaType, tfaToken);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UserApi#userNew");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **String**| Your email address. |
 **password** | **String**| Your password. |
 **country** | **String**| Country of residence. |
 **username** | **String**| Desired username. | [optional]
 **firstname** | **String**| First name. | [optional]
 **lastname** | **String**| Last name. | [optional]
 **acceptsTOS** | **String**| Set to true to indicate acceptance of the Terms of Service (https://www.bitmex.com/terms). | [optional]
 **referrerID** | **String**| Optional Referrer ID. | [optional]
 **tfaType** | **String**| Optional Two-Factor Type. Accepted values: GA, Yubikey, Clef | [optional]
 **tfaToken** | **String**| Two-Factor Token. | [optional]

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

<a name="userRequestEnableTFA"></a>
# **userRequestEnableTFA**
> Boolean userRequestEnableTFA(type)

Get Google Authenticator secret key for setting up two-factor auth. Fails if already enabled. Use /confirmEnableTFA for Yubikeys.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UserApi;


UserApi apiInstance = new UserApi();
String type = "type_example"; // String | Two-factor auth type. Supported types: 'GA' (Google Authenticator)
try {
    Boolean result = apiInstance.userRequestEnableTFA(type);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UserApi#userRequestEnableTFA");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **String**| Two-factor auth type. Supported types: &#39;GA&#39; (Google Authenticator) | [optional]

### Return type

**Boolean**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

<a name="userRequestPasswordReset"></a>
# **userRequestPasswordReset**
> Boolean userRequestPasswordReset(email)

Request a password reset.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UserApi;


UserApi apiInstance = new UserApi();
String email = "email_example"; // String | 
try {
    Boolean result = apiInstance.userRequestPasswordReset(email);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UserApi#userRequestPasswordReset");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **String**|  |

### Return type

**Boolean**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

<a name="userRequestWithdrawal"></a>
# **userRequestWithdrawal**
> Transaction userRequestWithdrawal(currency, amount, address, otpToken, fee)

Request a withdrawal to an external wallet.

This will send a confirmation email to the email address on record, unless requested via an API Key with the &#x60;withdraw&#x60; permission.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UserApi;


UserApi apiInstance = new UserApi();
String currency = "XBt"; // String | Currency you're withdrawing. Options: `XBt`
BigDecimal amount = new BigDecimal(); // BigDecimal | Amount of withdrawal currency.
String address = "address_example"; // String | Destination Address.
String otpToken = "otpToken_example"; // String | 2FA token. Required if 2FA is enabled on your account.
Double fee = 3.4D; // Double | Network fee for Bitcoin withdrawals. If not specified, a default value will be calculated based on Bitcoin network conditions. You will have a chance to confirm this via email.
try {
    Transaction result = apiInstance.userRequestWithdrawal(currency, amount, address, otpToken, fee);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UserApi#userRequestWithdrawal");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **String**| Currency you&#39;re withdrawing. Options: &#x60;XBt&#x60; | [default to XBt]
 **amount** | **BigDecimal**| Amount of withdrawal currency. |
 **address** | **String**| Destination Address. |
 **otpToken** | **String**| 2FA token. Required if 2FA is enabled on your account. | [optional]
 **fee** | **Double**| Network fee for Bitcoin withdrawals. If not specified, a default value will be calculated based on Bitcoin network conditions. You will have a chance to confirm this via email. | [optional]

### Return type

[**Transaction**](Transaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

<a name="userSavePreferences"></a>
# **userSavePreferences**
> User userSavePreferences(prefs, overwrite)

Save user preferences.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UserApi;


UserApi apiInstance = new UserApi();
String prefs = "prefs_example"; // String | 
Boolean overwrite = false; // Boolean | If true, will overwrite all existing preferences.
try {
    User result = apiInstance.userSavePreferences(prefs, overwrite);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UserApi#userSavePreferences");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **prefs** | **String**|  |
 **overwrite** | **Boolean**| If true, will overwrite all existing preferences. | [optional] [default to false]

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

<a name="userSendVerificationEmail"></a>
# **userSendVerificationEmail**
> Boolean userSendVerificationEmail(email)

Re-send verification email.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UserApi;


UserApi apiInstance = new UserApi();
String email = "email_example"; // String | 
try {
    Boolean result = apiInstance.userSendVerificationEmail(email);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UserApi#userSendVerificationEmail");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **String**|  |

### Return type

**Boolean**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

<a name="userUpdate"></a>
# **userUpdate**
> User userUpdate(firstname, lastname, oldPassword, newPassword, newPasswordConfirm, username, country, pgpPubKey)

Update your password, name, and other attributes.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UserApi;


UserApi apiInstance = new UserApi();
String firstname = "firstname_example"; // String | 
String lastname = "lastname_example"; // String | 
String oldPassword = "oldPassword_example"; // String | 
String newPassword = "newPassword_example"; // String | 
String newPasswordConfirm = "newPasswordConfirm_example"; // String | 
String username = "username_example"; // String | Username can only be set once. To reset, email support.
String country = "country_example"; // String | Country of residence.
String pgpPubKey = "pgpPubKey_example"; // String | PGP Public Key. If specified, automated emails will be sentwith this key.
try {
    User result = apiInstance.userUpdate(firstname, lastname, oldPassword, newPassword, newPasswordConfirm, username, country, pgpPubKey);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UserApi#userUpdate");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **firstname** | **String**|  | [optional]
 **lastname** | **String**|  | [optional]
 **oldPassword** | **String**|  | [optional]
 **newPassword** | **String**|  | [optional]
 **newPasswordConfirm** | **String**|  | [optional]
 **username** | **String**| Username can only be set once. To reset, email support. | [optional]
 **country** | **String**| Country of residence. | [optional]
 **pgpPubKey** | **String**| PGP Public Key. If specified, automated emails will be sentwith this key. | [optional]

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

