/**
 * BitMEX API
 * REST API for the BitMEX.com trading platform.<br><br><a href=\"/app/restAPI\">REST Documentation</a><br><a href=\"/app/wsAPI\">Websocket Documentation</a>
 *
 * OpenAPI spec version: 1.2.0
 * Contact: support@bitmex.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


package io.swagger.client.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.List;
import org.joda.time.LocalDate;


/**
 * UserPreferences
 */
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-07-05T09:40:48.217-05:00")
public class UserPreferences   {
  @JsonProperty("announcementsLastSeen")
  private LocalDate announcementsLastSeen = null;

  @JsonProperty("colorTheme")
  private String colorTheme = null;

  @JsonProperty("currency")
  private String currency = null;

  @JsonProperty("debug")
  private Boolean debug = null;

  @JsonProperty("disableEmails")
  private List<String> disableEmails = new ArrayList<String>();

  @JsonProperty("hideConfirmDialogs")
  private List<String> hideConfirmDialogs = new ArrayList<String>();

  @JsonProperty("hideConnectionModal")
  private Boolean hideConnectionModal = null;

  @JsonProperty("hideFromLeaderboard")
  private Boolean hideFromLeaderboard = false;

  @JsonProperty("hideNameFromLeaderboard")
  private Boolean hideNameFromLeaderboard = true;

  @JsonProperty("hideNotifications")
  private List<String> hideNotifications = new ArrayList<String>();

  @JsonProperty("hidePhoneConfirm")
  private Boolean hidePhoneConfirm = null;

  @JsonProperty("locale")
  private String locale = null;

  @JsonProperty("msgsSeen")
  private List<String> msgsSeen = new ArrayList<String>();

  @JsonProperty("orderBookBinning")
  private BigDecimal orderBookBinning = null;

  @JsonProperty("orderBookType")
  private String orderBookType = null;

  @JsonProperty("orderControlsPlusMinus")
  private Boolean orderControlsPlusMinus = null;

  @JsonProperty("sounds")
  private List<String> sounds = new ArrayList<String>();

  @JsonProperty("strictIPCheck")
  private Boolean strictIPCheck = false;

  @JsonProperty("strictTimeout")
  private Boolean strictTimeout = true;

  @JsonProperty("tickerGroup")
  private String tickerGroup = null;

  @JsonProperty("tickerPinned")
  private Boolean tickerPinned = null;

  @JsonProperty("tradeLayout")
  private String tradeLayout = null;

  public UserPreferences announcementsLastSeen(LocalDate announcementsLastSeen) {
    this.announcementsLastSeen = announcementsLastSeen;
    return this;
  }

   /**
   * Get announcementsLastSeen
   * @return announcementsLastSeen
  **/
  @ApiModelProperty(example = "null", value = "")
  public LocalDate getAnnouncementsLastSeen() {
    return announcementsLastSeen;
  }

  public void setAnnouncementsLastSeen(LocalDate announcementsLastSeen) {
    this.announcementsLastSeen = announcementsLastSeen;
  }

  public UserPreferences colorTheme(String colorTheme) {
    this.colorTheme = colorTheme;
    return this;
  }

   /**
   * Get colorTheme
   * @return colorTheme
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getColorTheme() {
    return colorTheme;
  }

  public void setColorTheme(String colorTheme) {
    this.colorTheme = colorTheme;
  }

  public UserPreferences currency(String currency) {
    this.currency = currency;
    return this;
  }

   /**
   * Get currency
   * @return currency
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getCurrency() {
    return currency;
  }

  public void setCurrency(String currency) {
    this.currency = currency;
  }

  public UserPreferences debug(Boolean debug) {
    this.debug = debug;
    return this;
  }

   /**
   * Get debug
   * @return debug
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getDebug() {
    return debug;
  }

  public void setDebug(Boolean debug) {
    this.debug = debug;
  }

  public UserPreferences disableEmails(List<String> disableEmails) {
    this.disableEmails = disableEmails;
    return this;
  }

   /**
   * Get disableEmails
   * @return disableEmails
  **/
  @ApiModelProperty(example = "null", value = "")
  public List<String> getDisableEmails() {
    return disableEmails;
  }

  public void setDisableEmails(List<String> disableEmails) {
    this.disableEmails = disableEmails;
  }

  public UserPreferences hideConfirmDialogs(List<String> hideConfirmDialogs) {
    this.hideConfirmDialogs = hideConfirmDialogs;
    return this;
  }

   /**
   * Get hideConfirmDialogs
   * @return hideConfirmDialogs
  **/
  @ApiModelProperty(example = "null", value = "")
  public List<String> getHideConfirmDialogs() {
    return hideConfirmDialogs;
  }

  public void setHideConfirmDialogs(List<String> hideConfirmDialogs) {
    this.hideConfirmDialogs = hideConfirmDialogs;
  }

  public UserPreferences hideConnectionModal(Boolean hideConnectionModal) {
    this.hideConnectionModal = hideConnectionModal;
    return this;
  }

   /**
   * Get hideConnectionModal
   * @return hideConnectionModal
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getHideConnectionModal() {
    return hideConnectionModal;
  }

  public void setHideConnectionModal(Boolean hideConnectionModal) {
    this.hideConnectionModal = hideConnectionModal;
  }

  public UserPreferences hideFromLeaderboard(Boolean hideFromLeaderboard) {
    this.hideFromLeaderboard = hideFromLeaderboard;
    return this;
  }

   /**
   * Get hideFromLeaderboard
   * @return hideFromLeaderboard
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getHideFromLeaderboard() {
    return hideFromLeaderboard;
  }

  public void setHideFromLeaderboard(Boolean hideFromLeaderboard) {
    this.hideFromLeaderboard = hideFromLeaderboard;
  }

  public UserPreferences hideNameFromLeaderboard(Boolean hideNameFromLeaderboard) {
    this.hideNameFromLeaderboard = hideNameFromLeaderboard;
    return this;
  }

   /**
   * Get hideNameFromLeaderboard
   * @return hideNameFromLeaderboard
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getHideNameFromLeaderboard() {
    return hideNameFromLeaderboard;
  }

  public void setHideNameFromLeaderboard(Boolean hideNameFromLeaderboard) {
    this.hideNameFromLeaderboard = hideNameFromLeaderboard;
  }

  public UserPreferences hideNotifications(List<String> hideNotifications) {
    this.hideNotifications = hideNotifications;
    return this;
  }

   /**
   * Get hideNotifications
   * @return hideNotifications
  **/
  @ApiModelProperty(example = "null", value = "")
  public List<String> getHideNotifications() {
    return hideNotifications;
  }

  public void setHideNotifications(List<String> hideNotifications) {
    this.hideNotifications = hideNotifications;
  }

  public UserPreferences hidePhoneConfirm(Boolean hidePhoneConfirm) {
    this.hidePhoneConfirm = hidePhoneConfirm;
    return this;
  }

   /**
   * Get hidePhoneConfirm
   * @return hidePhoneConfirm
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getHidePhoneConfirm() {
    return hidePhoneConfirm;
  }

  public void setHidePhoneConfirm(Boolean hidePhoneConfirm) {
    this.hidePhoneConfirm = hidePhoneConfirm;
  }

  public UserPreferences locale(String locale) {
    this.locale = locale;
    return this;
  }

   /**
   * Get locale
   * @return locale
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getLocale() {
    return locale;
  }

  public void setLocale(String locale) {
    this.locale = locale;
  }

  public UserPreferences msgsSeen(List<String> msgsSeen) {
    this.msgsSeen = msgsSeen;
    return this;
  }

   /**
   * Get msgsSeen
   * @return msgsSeen
  **/
  @ApiModelProperty(example = "null", value = "")
  public List<String> getMsgsSeen() {
    return msgsSeen;
  }

  public void setMsgsSeen(List<String> msgsSeen) {
    this.msgsSeen = msgsSeen;
  }

  public UserPreferences orderBookBinning(BigDecimal orderBookBinning) {
    this.orderBookBinning = orderBookBinning;
    return this;
  }

   /**
   * Get orderBookBinning
   * @return orderBookBinning
  **/
  @ApiModelProperty(example = "null", value = "")
  public BigDecimal getOrderBookBinning() {
    return orderBookBinning;
  }

  public void setOrderBookBinning(BigDecimal orderBookBinning) {
    this.orderBookBinning = orderBookBinning;
  }

  public UserPreferences orderBookType(String orderBookType) {
    this.orderBookType = orderBookType;
    return this;
  }

   /**
   * Get orderBookType
   * @return orderBookType
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getOrderBookType() {
    return orderBookType;
  }

  public void setOrderBookType(String orderBookType) {
    this.orderBookType = orderBookType;
  }

  public UserPreferences orderControlsPlusMinus(Boolean orderControlsPlusMinus) {
    this.orderControlsPlusMinus = orderControlsPlusMinus;
    return this;
  }

   /**
   * Get orderControlsPlusMinus
   * @return orderControlsPlusMinus
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getOrderControlsPlusMinus() {
    return orderControlsPlusMinus;
  }

  public void setOrderControlsPlusMinus(Boolean orderControlsPlusMinus) {
    this.orderControlsPlusMinus = orderControlsPlusMinus;
  }

  public UserPreferences sounds(List<String> sounds) {
    this.sounds = sounds;
    return this;
  }

   /**
   * Get sounds
   * @return sounds
  **/
  @ApiModelProperty(example = "null", value = "")
  public List<String> getSounds() {
    return sounds;
  }

  public void setSounds(List<String> sounds) {
    this.sounds = sounds;
  }

  public UserPreferences strictIPCheck(Boolean strictIPCheck) {
    this.strictIPCheck = strictIPCheck;
    return this;
  }

   /**
   * Get strictIPCheck
   * @return strictIPCheck
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getStrictIPCheck() {
    return strictIPCheck;
  }

  public void setStrictIPCheck(Boolean strictIPCheck) {
    this.strictIPCheck = strictIPCheck;
  }

  public UserPreferences strictTimeout(Boolean strictTimeout) {
    this.strictTimeout = strictTimeout;
    return this;
  }

   /**
   * Get strictTimeout
   * @return strictTimeout
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getStrictTimeout() {
    return strictTimeout;
  }

  public void setStrictTimeout(Boolean strictTimeout) {
    this.strictTimeout = strictTimeout;
  }

  public UserPreferences tickerGroup(String tickerGroup) {
    this.tickerGroup = tickerGroup;
    return this;
  }

   /**
   * Get tickerGroup
   * @return tickerGroup
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getTickerGroup() {
    return tickerGroup;
  }

  public void setTickerGroup(String tickerGroup) {
    this.tickerGroup = tickerGroup;
  }

  public UserPreferences tickerPinned(Boolean tickerPinned) {
    this.tickerPinned = tickerPinned;
    return this;
  }

   /**
   * Get tickerPinned
   * @return tickerPinned
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getTickerPinned() {
    return tickerPinned;
  }

  public void setTickerPinned(Boolean tickerPinned) {
    this.tickerPinned = tickerPinned;
  }

  public UserPreferences tradeLayout(String tradeLayout) {
    this.tradeLayout = tradeLayout;
    return this;
  }

   /**
   * Get tradeLayout
   * @return tradeLayout
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getTradeLayout() {
    return tradeLayout;
  }

  public void setTradeLayout(String tradeLayout) {
    this.tradeLayout = tradeLayout;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    UserPreferences userPreferences = (UserPreferences) o;
    return Objects.equals(this.announcementsLastSeen, userPreferences.announcementsLastSeen) &&
        Objects.equals(this.colorTheme, userPreferences.colorTheme) &&
        Objects.equals(this.currency, userPreferences.currency) &&
        Objects.equals(this.debug, userPreferences.debug) &&
        Objects.equals(this.disableEmails, userPreferences.disableEmails) &&
        Objects.equals(this.hideConfirmDialogs, userPreferences.hideConfirmDialogs) &&
        Objects.equals(this.hideConnectionModal, userPreferences.hideConnectionModal) &&
        Objects.equals(this.hideFromLeaderboard, userPreferences.hideFromLeaderboard) &&
        Objects.equals(this.hideNameFromLeaderboard, userPreferences.hideNameFromLeaderboard) &&
        Objects.equals(this.hideNotifications, userPreferences.hideNotifications) &&
        Objects.equals(this.hidePhoneConfirm, userPreferences.hidePhoneConfirm) &&
        Objects.equals(this.locale, userPreferences.locale) &&
        Objects.equals(this.msgsSeen, userPreferences.msgsSeen) &&
        Objects.equals(this.orderBookBinning, userPreferences.orderBookBinning) &&
        Objects.equals(this.orderBookType, userPreferences.orderBookType) &&
        Objects.equals(this.orderControlsPlusMinus, userPreferences.orderControlsPlusMinus) &&
        Objects.equals(this.sounds, userPreferences.sounds) &&
        Objects.equals(this.strictIPCheck, userPreferences.strictIPCheck) &&
        Objects.equals(this.strictTimeout, userPreferences.strictTimeout) &&
        Objects.equals(this.tickerGroup, userPreferences.tickerGroup) &&
        Objects.equals(this.tickerPinned, userPreferences.tickerPinned) &&
        Objects.equals(this.tradeLayout, userPreferences.tradeLayout);
  }

  @Override
  public int hashCode() {
    return Objects.hash(announcementsLastSeen, colorTheme, currency, debug, disableEmails, hideConfirmDialogs, hideConnectionModal, hideFromLeaderboard, hideNameFromLeaderboard, hideNotifications, hidePhoneConfirm, locale, msgsSeen, orderBookBinning, orderBookType, orderControlsPlusMinus, sounds, strictIPCheck, strictTimeout, tickerGroup, tickerPinned, tradeLayout);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class UserPreferences {\n");
    
    sb.append("    announcementsLastSeen: ").append(toIndentedString(announcementsLastSeen)).append("\n");
    sb.append("    colorTheme: ").append(toIndentedString(colorTheme)).append("\n");
    sb.append("    currency: ").append(toIndentedString(currency)).append("\n");
    sb.append("    debug: ").append(toIndentedString(debug)).append("\n");
    sb.append("    disableEmails: ").append(toIndentedString(disableEmails)).append("\n");
    sb.append("    hideConfirmDialogs: ").append(toIndentedString(hideConfirmDialogs)).append("\n");
    sb.append("    hideConnectionModal: ").append(toIndentedString(hideConnectionModal)).append("\n");
    sb.append("    hideFromLeaderboard: ").append(toIndentedString(hideFromLeaderboard)).append("\n");
    sb.append("    hideNameFromLeaderboard: ").append(toIndentedString(hideNameFromLeaderboard)).append("\n");
    sb.append("    hideNotifications: ").append(toIndentedString(hideNotifications)).append("\n");
    sb.append("    hidePhoneConfirm: ").append(toIndentedString(hidePhoneConfirm)).append("\n");
    sb.append("    locale: ").append(toIndentedString(locale)).append("\n");
    sb.append("    msgsSeen: ").append(toIndentedString(msgsSeen)).append("\n");
    sb.append("    orderBookBinning: ").append(toIndentedString(orderBookBinning)).append("\n");
    sb.append("    orderBookType: ").append(toIndentedString(orderBookType)).append("\n");
    sb.append("    orderControlsPlusMinus: ").append(toIndentedString(orderControlsPlusMinus)).append("\n");
    sb.append("    sounds: ").append(toIndentedString(sounds)).append("\n");
    sb.append("    strictIPCheck: ").append(toIndentedString(strictIPCheck)).append("\n");
    sb.append("    strictTimeout: ").append(toIndentedString(strictTimeout)).append("\n");
    sb.append("    tickerGroup: ").append(toIndentedString(tickerGroup)).append("\n");
    sb.append("    tickerPinned: ").append(toIndentedString(tickerPinned)).append("\n");
    sb.append("    tradeLayout: ").append(toIndentedString(tradeLayout)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
}

