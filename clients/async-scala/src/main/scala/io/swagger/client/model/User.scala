package io.swagger.client.model

import org.joda.time.DateTime


case class User (
  id: Number,
  ownerId: Number,
  firstname: String,
  lastname: String,
  status: String,
  username: String,
  email: String,
  phone: String,
  countryCode: Number,
  created: Date,
  lastUpdated: Date,
  preferences: UserPreferences,
  TFAEnabled: String,
  affiliateID: String,
  pgpPubKey: String,
  country: String,
  disabled: Boolean
  
)
