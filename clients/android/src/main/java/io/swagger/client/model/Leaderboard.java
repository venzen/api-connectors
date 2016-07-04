package io.swagger.client.model;


import io.swagger.annotations.*;
import com.google.gson.annotations.SerializedName;


@ApiModel(description = "")
public class Leaderboard  {
  
  @SerializedName("name")
  private String name = null;
  @SerializedName("isRealName")
  private Boolean isRealName = null;
  @SerializedName("isMe")
  private Boolean isMe = null;
  @SerializedName("profit")
  private Double profit = null;

  
  /**
   **/
  @ApiModelProperty(required = true, value = "")
  public String getName() {
    return name;
  }
  public void setName(String name) {
    this.name = name;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  public Boolean getIsRealName() {
    return isRealName;
  }
  public void setIsRealName(Boolean isRealName) {
    this.isRealName = isRealName;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  public Boolean getIsMe() {
    return isMe;
  }
  public void setIsMe(Boolean isMe) {
    this.isMe = isMe;
  }

  
  /**
   **/
  @ApiModelProperty(value = "")
  public Double getProfit() {
    return profit;
  }
  public void setProfit(Double profit) {
    this.profit = profit;
  }

  

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class Leaderboard {\n");
    
    sb.append("  name: ").append(name).append("\n");
    sb.append("  isRealName: ").append(isRealName).append("\n");
    sb.append("  isMe: ").append(isMe).append("\n");
    sb.append("  profit: ").append(profit).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}
