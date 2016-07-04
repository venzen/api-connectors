package io.swagger.client.model

import org.joda.time.DateTime


case class Instrument (
  symbol: String,
  rootSymbol: String,
  state: String,
  typ: String,
  listing: Date,
  front: Date,
  expiry: Date,
  settle: Date,
  relistInterval: Date,
  inverseLeg: String,
  sellLeg: String,
  buyLeg: String,
  positionCurrency: String,
  underlying: String,
  quoteCurrency: String,
  underlyingSymbol: String,
  reference: String,
  referenceSymbol: String,
  calcInterval: Date,
  publishInterval: Date,
  publishTime: Date,
  maxOrderQty: Number,
  maxPrice: Double,
  lotSize: Number,
  tickSize: Double,
  multiplier: Number,
  settlCurrency: String,
  underlyingToPositionMultiplier: Number,
  underlyingToSettleMultiplier: Number,
  quoteToSettleMultiplier: Number,
  isQuanto: Boolean,
  isInverse: Boolean,
  initMargin: Double,
  maintMargin: Double,
  limit: Double,
  capped: Boolean,
  taxed: Boolean,
  makerFee: Double,
  takerFee: Double,
  settlementFee: Double,
  insuranceFee: Double,
  fundingBaseSymbol: String,
  fundingQuoteSymbol: String,
  fundingPremiumSymbol: String,
  fundingTimestamp: Date,
  fundingInterval: Date,
  fundingRate: Double,
  indicativeFundingRate: Double,
  rebalanceTimestamp: Date,
  rebalanceInterval: Date,
  openingTimestamp: Date,
  closingTimestamp: Date,
  sessionInterval: Date,
  prevClosePrice: Double,
  limitDownPrice: Double,
  limitUpPrice: Double,
  bankruptLimitDownPrice: Double,
  bankruptLimitUpPrice: Double,
  prevTotalVolume: Number,
  totalVolume: Number,
  volume: Number,
  volume24h: Number,
  prevTotalTurnover: Number,
  totalTurnover: Number,
  turnover: Number,
  turnover24h: Number,
  prevPrice24h: Double,
  vwap: Double,
  highPrice: Double,
  lowPrice: Double,
  lastPrice: Double,
  lastPriceProtected: Double,
  lastTickDirection: String,
  lastChangePcnt: Double,
  bidPrice: Double,
  midPrice: Double,
  askPrice: Double,
  impactBidPrice: Double,
  impactMidPrice: Double,
  impactAskPrice: Double,
  hasLiquidity: Boolean,
  openInterest: Number,
  openValue: Number,
  fairMethod: String,
  fairBasisRate: Double,
  fairBasis: Double,
  fairPrice: Double,
  markMethod: String,
  markPrice: Double,
  indicativeTaxRate: Double,
  indicativeSettlePrice: Double,
  settledPrice: Double,
  timestamp: Date
  
)
