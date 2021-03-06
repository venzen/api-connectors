/* 
 * BitMEX API
 *
 * REST API for the BitMEX.com trading platform.<br><br><a href=\"/app/restAPI\">REST Documentation</a><br><a href=\"/app/wsAPI\">Websocket Documentation</a>
 *
 * OpenAPI spec version: 1.2.0
 * Contact: support@bitmex.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Margin
    /// </summary>
    [DataContract]
    public partial class Margin :  IEquatable<Margin>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Margin" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Margin() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Margin" /> class.
        /// </summary>
        /// <param name="Account">Account (required).</param>
        /// <param name="Currency">Currency (required).</param>
        /// <param name="RiskLimit">RiskLimit.</param>
        /// <param name="PrevState">PrevState.</param>
        /// <param name="State">State.</param>
        /// <param name="Action">Action.</param>
        /// <param name="Amount">Amount.</param>
        /// <param name="PendingCredit">PendingCredit.</param>
        /// <param name="PendingDebit">PendingDebit.</param>
        /// <param name="ConfirmedDebit">ConfirmedDebit.</param>
        /// <param name="PrevRealisedPnl">PrevRealisedPnl.</param>
        /// <param name="PrevUnrealisedPnl">PrevUnrealisedPnl.</param>
        /// <param name="GrossComm">GrossComm.</param>
        /// <param name="GrossOpenCost">GrossOpenCost.</param>
        /// <param name="GrossOpenPremium">GrossOpenPremium.</param>
        /// <param name="GrossExecCost">GrossExecCost.</param>
        /// <param name="GrossMarkValue">GrossMarkValue.</param>
        /// <param name="RiskValue">RiskValue.</param>
        /// <param name="TaxableMargin">TaxableMargin.</param>
        /// <param name="InitMargin">InitMargin.</param>
        /// <param name="MaintMargin">MaintMargin.</param>
        /// <param name="SessionMargin">SessionMargin.</param>
        /// <param name="TargetExcessMargin">TargetExcessMargin.</param>
        /// <param name="VarMargin">VarMargin.</param>
        /// <param name="RealisedPnl">RealisedPnl.</param>
        /// <param name="UnrealisedPnl">UnrealisedPnl.</param>
        /// <param name="IndicativeTax">IndicativeTax.</param>
        /// <param name="UnrealisedProfit">UnrealisedProfit.</param>
        /// <param name="SyntheticMargin">SyntheticMargin.</param>
        /// <param name="WalletBalance">WalletBalance.</param>
        /// <param name="MarginBalance">MarginBalance.</param>
        /// <param name="MarginBalancePcnt">MarginBalancePcnt (default to 0.0).</param>
        /// <param name="MarginLeverage">MarginLeverage (default to 0.0).</param>
        /// <param name="MarginUsedPcnt">MarginUsedPcnt (default to 0.0).</param>
        /// <param name="ExcessMargin">ExcessMargin.</param>
        /// <param name="ExcessMarginPcnt">ExcessMarginPcnt (default to 0.0).</param>
        /// <param name="AvailableMargin">AvailableMargin.</param>
        /// <param name="WithdrawableMargin">WithdrawableMargin.</param>
        /// <param name="Timestamp">Timestamp.</param>
        /// <param name="GrossLastValue">GrossLastValue.</param>
        /// <param name="Commission">Commission (default to 0.0).</param>
        public Margin(decimal? Account = null, string Currency = null, decimal? RiskLimit = null, string PrevState = null, string State = null, string Action = null, decimal? Amount = null, decimal? PendingCredit = null, decimal? PendingDebit = null, decimal? ConfirmedDebit = null, decimal? PrevRealisedPnl = null, decimal? PrevUnrealisedPnl = null, decimal? GrossComm = null, decimal? GrossOpenCost = null, decimal? GrossOpenPremium = null, decimal? GrossExecCost = null, decimal? GrossMarkValue = null, decimal? RiskValue = null, decimal? TaxableMargin = null, decimal? InitMargin = null, decimal? MaintMargin = null, decimal? SessionMargin = null, decimal? TargetExcessMargin = null, decimal? VarMargin = null, decimal? RealisedPnl = null, decimal? UnrealisedPnl = null, decimal? IndicativeTax = null, decimal? UnrealisedProfit = null, decimal? SyntheticMargin = null, decimal? WalletBalance = null, decimal? MarginBalance = null, double? MarginBalancePcnt = null, double? MarginLeverage = null, double? MarginUsedPcnt = null, decimal? ExcessMargin = null, double? ExcessMarginPcnt = null, decimal? AvailableMargin = null, decimal? WithdrawableMargin = null, DateTime? Timestamp = null, decimal? GrossLastValue = null, double? Commission = null)
        {
            // to ensure "Account" is required (not null)
            if (Account == null)
            {
                throw new InvalidDataException("Account is a required property for Margin and cannot be null");
            }
            else
            {
                this.Account = Account;
            }
            // to ensure "Currency" is required (not null)
            if (Currency == null)
            {
                throw new InvalidDataException("Currency is a required property for Margin and cannot be null");
            }
            else
            {
                this.Currency = Currency;
            }
            this.RiskLimit = RiskLimit;
            this.PrevState = PrevState;
            this.State = State;
            this.Action = Action;
            this.Amount = Amount;
            this.PendingCredit = PendingCredit;
            this.PendingDebit = PendingDebit;
            this.ConfirmedDebit = ConfirmedDebit;
            this.PrevRealisedPnl = PrevRealisedPnl;
            this.PrevUnrealisedPnl = PrevUnrealisedPnl;
            this.GrossComm = GrossComm;
            this.GrossOpenCost = GrossOpenCost;
            this.GrossOpenPremium = GrossOpenPremium;
            this.GrossExecCost = GrossExecCost;
            this.GrossMarkValue = GrossMarkValue;
            this.RiskValue = RiskValue;
            this.TaxableMargin = TaxableMargin;
            this.InitMargin = InitMargin;
            this.MaintMargin = MaintMargin;
            this.SessionMargin = SessionMargin;
            this.TargetExcessMargin = TargetExcessMargin;
            this.VarMargin = VarMargin;
            this.RealisedPnl = RealisedPnl;
            this.UnrealisedPnl = UnrealisedPnl;
            this.IndicativeTax = IndicativeTax;
            this.UnrealisedProfit = UnrealisedProfit;
            this.SyntheticMargin = SyntheticMargin;
            this.WalletBalance = WalletBalance;
            this.MarginBalance = MarginBalance;
            // use default value if no "MarginBalancePcnt" provided
            if (MarginBalancePcnt == null)
            {
                this.MarginBalancePcnt = 0.0;
            }
            else
            {
                this.MarginBalancePcnt = MarginBalancePcnt;
            }
            // use default value if no "MarginLeverage" provided
            if (MarginLeverage == null)
            {
                this.MarginLeverage = 0.0;
            }
            else
            {
                this.MarginLeverage = MarginLeverage;
            }
            // use default value if no "MarginUsedPcnt" provided
            if (MarginUsedPcnt == null)
            {
                this.MarginUsedPcnt = 0.0;
            }
            else
            {
                this.MarginUsedPcnt = MarginUsedPcnt;
            }
            this.ExcessMargin = ExcessMargin;
            // use default value if no "ExcessMarginPcnt" provided
            if (ExcessMarginPcnt == null)
            {
                this.ExcessMarginPcnt = 0.0;
            }
            else
            {
                this.ExcessMarginPcnt = ExcessMarginPcnt;
            }
            this.AvailableMargin = AvailableMargin;
            this.WithdrawableMargin = WithdrawableMargin;
            this.Timestamp = Timestamp;
            this.GrossLastValue = GrossLastValue;
            // use default value if no "Commission" provided
            if (Commission == null)
            {
                this.Commission = 0.0;
            }
            else
            {
                this.Commission = Commission;
            }
        }
        
        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public decimal? Account { get; set; }
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }
        /// <summary>
        /// Gets or Sets RiskLimit
        /// </summary>
        [DataMember(Name="riskLimit", EmitDefaultValue=false)]
        public decimal? RiskLimit { get; set; }
        /// <summary>
        /// Gets or Sets PrevState
        /// </summary>
        [DataMember(Name="prevState", EmitDefaultValue=false)]
        public string PrevState { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }
        /// <summary>
        /// Gets or Sets PendingCredit
        /// </summary>
        [DataMember(Name="pendingCredit", EmitDefaultValue=false)]
        public decimal? PendingCredit { get; set; }
        /// <summary>
        /// Gets or Sets PendingDebit
        /// </summary>
        [DataMember(Name="pendingDebit", EmitDefaultValue=false)]
        public decimal? PendingDebit { get; set; }
        /// <summary>
        /// Gets or Sets ConfirmedDebit
        /// </summary>
        [DataMember(Name="confirmedDebit", EmitDefaultValue=false)]
        public decimal? ConfirmedDebit { get; set; }
        /// <summary>
        /// Gets or Sets PrevRealisedPnl
        /// </summary>
        [DataMember(Name="prevRealisedPnl", EmitDefaultValue=false)]
        public decimal? PrevRealisedPnl { get; set; }
        /// <summary>
        /// Gets or Sets PrevUnrealisedPnl
        /// </summary>
        [DataMember(Name="prevUnrealisedPnl", EmitDefaultValue=false)]
        public decimal? PrevUnrealisedPnl { get; set; }
        /// <summary>
        /// Gets or Sets GrossComm
        /// </summary>
        [DataMember(Name="grossComm", EmitDefaultValue=false)]
        public decimal? GrossComm { get; set; }
        /// <summary>
        /// Gets or Sets GrossOpenCost
        /// </summary>
        [DataMember(Name="grossOpenCost", EmitDefaultValue=false)]
        public decimal? GrossOpenCost { get; set; }
        /// <summary>
        /// Gets or Sets GrossOpenPremium
        /// </summary>
        [DataMember(Name="grossOpenPremium", EmitDefaultValue=false)]
        public decimal? GrossOpenPremium { get; set; }
        /// <summary>
        /// Gets or Sets GrossExecCost
        /// </summary>
        [DataMember(Name="grossExecCost", EmitDefaultValue=false)]
        public decimal? GrossExecCost { get; set; }
        /// <summary>
        /// Gets or Sets GrossMarkValue
        /// </summary>
        [DataMember(Name="grossMarkValue", EmitDefaultValue=false)]
        public decimal? GrossMarkValue { get; set; }
        /// <summary>
        /// Gets or Sets RiskValue
        /// </summary>
        [DataMember(Name="riskValue", EmitDefaultValue=false)]
        public decimal? RiskValue { get; set; }
        /// <summary>
        /// Gets or Sets TaxableMargin
        /// </summary>
        [DataMember(Name="taxableMargin", EmitDefaultValue=false)]
        public decimal? TaxableMargin { get; set; }
        /// <summary>
        /// Gets or Sets InitMargin
        /// </summary>
        [DataMember(Name="initMargin", EmitDefaultValue=false)]
        public decimal? InitMargin { get; set; }
        /// <summary>
        /// Gets or Sets MaintMargin
        /// </summary>
        [DataMember(Name="maintMargin", EmitDefaultValue=false)]
        public decimal? MaintMargin { get; set; }
        /// <summary>
        /// Gets or Sets SessionMargin
        /// </summary>
        [DataMember(Name="sessionMargin", EmitDefaultValue=false)]
        public decimal? SessionMargin { get; set; }
        /// <summary>
        /// Gets or Sets TargetExcessMargin
        /// </summary>
        [DataMember(Name="targetExcessMargin", EmitDefaultValue=false)]
        public decimal? TargetExcessMargin { get; set; }
        /// <summary>
        /// Gets or Sets VarMargin
        /// </summary>
        [DataMember(Name="varMargin", EmitDefaultValue=false)]
        public decimal? VarMargin { get; set; }
        /// <summary>
        /// Gets or Sets RealisedPnl
        /// </summary>
        [DataMember(Name="realisedPnl", EmitDefaultValue=false)]
        public decimal? RealisedPnl { get; set; }
        /// <summary>
        /// Gets or Sets UnrealisedPnl
        /// </summary>
        [DataMember(Name="unrealisedPnl", EmitDefaultValue=false)]
        public decimal? UnrealisedPnl { get; set; }
        /// <summary>
        /// Gets or Sets IndicativeTax
        /// </summary>
        [DataMember(Name="indicativeTax", EmitDefaultValue=false)]
        public decimal? IndicativeTax { get; set; }
        /// <summary>
        /// Gets or Sets UnrealisedProfit
        /// </summary>
        [DataMember(Name="unrealisedProfit", EmitDefaultValue=false)]
        public decimal? UnrealisedProfit { get; set; }
        /// <summary>
        /// Gets or Sets SyntheticMargin
        /// </summary>
        [DataMember(Name="syntheticMargin", EmitDefaultValue=false)]
        public decimal? SyntheticMargin { get; set; }
        /// <summary>
        /// Gets or Sets WalletBalance
        /// </summary>
        [DataMember(Name="walletBalance", EmitDefaultValue=false)]
        public decimal? WalletBalance { get; set; }
        /// <summary>
        /// Gets or Sets MarginBalance
        /// </summary>
        [DataMember(Name="marginBalance", EmitDefaultValue=false)]
        public decimal? MarginBalance { get; set; }
        /// <summary>
        /// Gets or Sets MarginBalancePcnt
        /// </summary>
        [DataMember(Name="marginBalancePcnt", EmitDefaultValue=false)]
        public double? MarginBalancePcnt { get; set; }
        /// <summary>
        /// Gets or Sets MarginLeverage
        /// </summary>
        [DataMember(Name="marginLeverage", EmitDefaultValue=false)]
        public double? MarginLeverage { get; set; }
        /// <summary>
        /// Gets or Sets MarginUsedPcnt
        /// </summary>
        [DataMember(Name="marginUsedPcnt", EmitDefaultValue=false)]
        public double? MarginUsedPcnt { get; set; }
        /// <summary>
        /// Gets or Sets ExcessMargin
        /// </summary>
        [DataMember(Name="excessMargin", EmitDefaultValue=false)]
        public decimal? ExcessMargin { get; set; }
        /// <summary>
        /// Gets or Sets ExcessMarginPcnt
        /// </summary>
        [DataMember(Name="excessMarginPcnt", EmitDefaultValue=false)]
        public double? ExcessMarginPcnt { get; set; }
        /// <summary>
        /// Gets or Sets AvailableMargin
        /// </summary>
        [DataMember(Name="availableMargin", EmitDefaultValue=false)]
        public decimal? AvailableMargin { get; set; }
        /// <summary>
        /// Gets or Sets WithdrawableMargin
        /// </summary>
        [DataMember(Name="withdrawableMargin", EmitDefaultValue=false)]
        public decimal? WithdrawableMargin { get; set; }
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// Gets or Sets GrossLastValue
        /// </summary>
        [DataMember(Name="grossLastValue", EmitDefaultValue=false)]
        public decimal? GrossLastValue { get; set; }
        /// <summary>
        /// Gets or Sets Commission
        /// </summary>
        [DataMember(Name="commission", EmitDefaultValue=false)]
        public double? Commission { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Margin {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  RiskLimit: ").Append(RiskLimit).Append("\n");
            sb.Append("  PrevState: ").Append(PrevState).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  PendingCredit: ").Append(PendingCredit).Append("\n");
            sb.Append("  PendingDebit: ").Append(PendingDebit).Append("\n");
            sb.Append("  ConfirmedDebit: ").Append(ConfirmedDebit).Append("\n");
            sb.Append("  PrevRealisedPnl: ").Append(PrevRealisedPnl).Append("\n");
            sb.Append("  PrevUnrealisedPnl: ").Append(PrevUnrealisedPnl).Append("\n");
            sb.Append("  GrossComm: ").Append(GrossComm).Append("\n");
            sb.Append("  GrossOpenCost: ").Append(GrossOpenCost).Append("\n");
            sb.Append("  GrossOpenPremium: ").Append(GrossOpenPremium).Append("\n");
            sb.Append("  GrossExecCost: ").Append(GrossExecCost).Append("\n");
            sb.Append("  GrossMarkValue: ").Append(GrossMarkValue).Append("\n");
            sb.Append("  RiskValue: ").Append(RiskValue).Append("\n");
            sb.Append("  TaxableMargin: ").Append(TaxableMargin).Append("\n");
            sb.Append("  InitMargin: ").Append(InitMargin).Append("\n");
            sb.Append("  MaintMargin: ").Append(MaintMargin).Append("\n");
            sb.Append("  SessionMargin: ").Append(SessionMargin).Append("\n");
            sb.Append("  TargetExcessMargin: ").Append(TargetExcessMargin).Append("\n");
            sb.Append("  VarMargin: ").Append(VarMargin).Append("\n");
            sb.Append("  RealisedPnl: ").Append(RealisedPnl).Append("\n");
            sb.Append("  UnrealisedPnl: ").Append(UnrealisedPnl).Append("\n");
            sb.Append("  IndicativeTax: ").Append(IndicativeTax).Append("\n");
            sb.Append("  UnrealisedProfit: ").Append(UnrealisedProfit).Append("\n");
            sb.Append("  SyntheticMargin: ").Append(SyntheticMargin).Append("\n");
            sb.Append("  WalletBalance: ").Append(WalletBalance).Append("\n");
            sb.Append("  MarginBalance: ").Append(MarginBalance).Append("\n");
            sb.Append("  MarginBalancePcnt: ").Append(MarginBalancePcnt).Append("\n");
            sb.Append("  MarginLeverage: ").Append(MarginLeverage).Append("\n");
            sb.Append("  MarginUsedPcnt: ").Append(MarginUsedPcnt).Append("\n");
            sb.Append("  ExcessMargin: ").Append(ExcessMargin).Append("\n");
            sb.Append("  ExcessMarginPcnt: ").Append(ExcessMarginPcnt).Append("\n");
            sb.Append("  AvailableMargin: ").Append(AvailableMargin).Append("\n");
            sb.Append("  WithdrawableMargin: ").Append(WithdrawableMargin).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  GrossLastValue: ").Append(GrossLastValue).Append("\n");
            sb.Append("  Commission: ").Append(Commission).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Margin);
        }

        /// <summary>
        /// Returns true if Margin instances are equal
        /// </summary>
        /// <param name="other">Instance of Margin to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Margin other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Account == other.Account ||
                    this.Account != null &&
                    this.Account.Equals(other.Account)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.RiskLimit == other.RiskLimit ||
                    this.RiskLimit != null &&
                    this.RiskLimit.Equals(other.RiskLimit)
                ) && 
                (
                    this.PrevState == other.PrevState ||
                    this.PrevState != null &&
                    this.PrevState.Equals(other.PrevState)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.PendingCredit == other.PendingCredit ||
                    this.PendingCredit != null &&
                    this.PendingCredit.Equals(other.PendingCredit)
                ) && 
                (
                    this.PendingDebit == other.PendingDebit ||
                    this.PendingDebit != null &&
                    this.PendingDebit.Equals(other.PendingDebit)
                ) && 
                (
                    this.ConfirmedDebit == other.ConfirmedDebit ||
                    this.ConfirmedDebit != null &&
                    this.ConfirmedDebit.Equals(other.ConfirmedDebit)
                ) && 
                (
                    this.PrevRealisedPnl == other.PrevRealisedPnl ||
                    this.PrevRealisedPnl != null &&
                    this.PrevRealisedPnl.Equals(other.PrevRealisedPnl)
                ) && 
                (
                    this.PrevUnrealisedPnl == other.PrevUnrealisedPnl ||
                    this.PrevUnrealisedPnl != null &&
                    this.PrevUnrealisedPnl.Equals(other.PrevUnrealisedPnl)
                ) && 
                (
                    this.GrossComm == other.GrossComm ||
                    this.GrossComm != null &&
                    this.GrossComm.Equals(other.GrossComm)
                ) && 
                (
                    this.GrossOpenCost == other.GrossOpenCost ||
                    this.GrossOpenCost != null &&
                    this.GrossOpenCost.Equals(other.GrossOpenCost)
                ) && 
                (
                    this.GrossOpenPremium == other.GrossOpenPremium ||
                    this.GrossOpenPremium != null &&
                    this.GrossOpenPremium.Equals(other.GrossOpenPremium)
                ) && 
                (
                    this.GrossExecCost == other.GrossExecCost ||
                    this.GrossExecCost != null &&
                    this.GrossExecCost.Equals(other.GrossExecCost)
                ) && 
                (
                    this.GrossMarkValue == other.GrossMarkValue ||
                    this.GrossMarkValue != null &&
                    this.GrossMarkValue.Equals(other.GrossMarkValue)
                ) && 
                (
                    this.RiskValue == other.RiskValue ||
                    this.RiskValue != null &&
                    this.RiskValue.Equals(other.RiskValue)
                ) && 
                (
                    this.TaxableMargin == other.TaxableMargin ||
                    this.TaxableMargin != null &&
                    this.TaxableMargin.Equals(other.TaxableMargin)
                ) && 
                (
                    this.InitMargin == other.InitMargin ||
                    this.InitMargin != null &&
                    this.InitMargin.Equals(other.InitMargin)
                ) && 
                (
                    this.MaintMargin == other.MaintMargin ||
                    this.MaintMargin != null &&
                    this.MaintMargin.Equals(other.MaintMargin)
                ) && 
                (
                    this.SessionMargin == other.SessionMargin ||
                    this.SessionMargin != null &&
                    this.SessionMargin.Equals(other.SessionMargin)
                ) && 
                (
                    this.TargetExcessMargin == other.TargetExcessMargin ||
                    this.TargetExcessMargin != null &&
                    this.TargetExcessMargin.Equals(other.TargetExcessMargin)
                ) && 
                (
                    this.VarMargin == other.VarMargin ||
                    this.VarMargin != null &&
                    this.VarMargin.Equals(other.VarMargin)
                ) && 
                (
                    this.RealisedPnl == other.RealisedPnl ||
                    this.RealisedPnl != null &&
                    this.RealisedPnl.Equals(other.RealisedPnl)
                ) && 
                (
                    this.UnrealisedPnl == other.UnrealisedPnl ||
                    this.UnrealisedPnl != null &&
                    this.UnrealisedPnl.Equals(other.UnrealisedPnl)
                ) && 
                (
                    this.IndicativeTax == other.IndicativeTax ||
                    this.IndicativeTax != null &&
                    this.IndicativeTax.Equals(other.IndicativeTax)
                ) && 
                (
                    this.UnrealisedProfit == other.UnrealisedProfit ||
                    this.UnrealisedProfit != null &&
                    this.UnrealisedProfit.Equals(other.UnrealisedProfit)
                ) && 
                (
                    this.SyntheticMargin == other.SyntheticMargin ||
                    this.SyntheticMargin != null &&
                    this.SyntheticMargin.Equals(other.SyntheticMargin)
                ) && 
                (
                    this.WalletBalance == other.WalletBalance ||
                    this.WalletBalance != null &&
                    this.WalletBalance.Equals(other.WalletBalance)
                ) && 
                (
                    this.MarginBalance == other.MarginBalance ||
                    this.MarginBalance != null &&
                    this.MarginBalance.Equals(other.MarginBalance)
                ) && 
                (
                    this.MarginBalancePcnt == other.MarginBalancePcnt ||
                    this.MarginBalancePcnt != null &&
                    this.MarginBalancePcnt.Equals(other.MarginBalancePcnt)
                ) && 
                (
                    this.MarginLeverage == other.MarginLeverage ||
                    this.MarginLeverage != null &&
                    this.MarginLeverage.Equals(other.MarginLeverage)
                ) && 
                (
                    this.MarginUsedPcnt == other.MarginUsedPcnt ||
                    this.MarginUsedPcnt != null &&
                    this.MarginUsedPcnt.Equals(other.MarginUsedPcnt)
                ) && 
                (
                    this.ExcessMargin == other.ExcessMargin ||
                    this.ExcessMargin != null &&
                    this.ExcessMargin.Equals(other.ExcessMargin)
                ) && 
                (
                    this.ExcessMarginPcnt == other.ExcessMarginPcnt ||
                    this.ExcessMarginPcnt != null &&
                    this.ExcessMarginPcnt.Equals(other.ExcessMarginPcnt)
                ) && 
                (
                    this.AvailableMargin == other.AvailableMargin ||
                    this.AvailableMargin != null &&
                    this.AvailableMargin.Equals(other.AvailableMargin)
                ) && 
                (
                    this.WithdrawableMargin == other.WithdrawableMargin ||
                    this.WithdrawableMargin != null &&
                    this.WithdrawableMargin.Equals(other.WithdrawableMargin)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.GrossLastValue == other.GrossLastValue ||
                    this.GrossLastValue != null &&
                    this.GrossLastValue.Equals(other.GrossLastValue)
                ) && 
                (
                    this.Commission == other.Commission ||
                    this.Commission != null &&
                    this.Commission.Equals(other.Commission)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Account != null)
                    hash = hash * 59 + this.Account.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.RiskLimit != null)
                    hash = hash * 59 + this.RiskLimit.GetHashCode();
                if (this.PrevState != null)
                    hash = hash * 59 + this.PrevState.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.PendingCredit != null)
                    hash = hash * 59 + this.PendingCredit.GetHashCode();
                if (this.PendingDebit != null)
                    hash = hash * 59 + this.PendingDebit.GetHashCode();
                if (this.ConfirmedDebit != null)
                    hash = hash * 59 + this.ConfirmedDebit.GetHashCode();
                if (this.PrevRealisedPnl != null)
                    hash = hash * 59 + this.PrevRealisedPnl.GetHashCode();
                if (this.PrevUnrealisedPnl != null)
                    hash = hash * 59 + this.PrevUnrealisedPnl.GetHashCode();
                if (this.GrossComm != null)
                    hash = hash * 59 + this.GrossComm.GetHashCode();
                if (this.GrossOpenCost != null)
                    hash = hash * 59 + this.GrossOpenCost.GetHashCode();
                if (this.GrossOpenPremium != null)
                    hash = hash * 59 + this.GrossOpenPremium.GetHashCode();
                if (this.GrossExecCost != null)
                    hash = hash * 59 + this.GrossExecCost.GetHashCode();
                if (this.GrossMarkValue != null)
                    hash = hash * 59 + this.GrossMarkValue.GetHashCode();
                if (this.RiskValue != null)
                    hash = hash * 59 + this.RiskValue.GetHashCode();
                if (this.TaxableMargin != null)
                    hash = hash * 59 + this.TaxableMargin.GetHashCode();
                if (this.InitMargin != null)
                    hash = hash * 59 + this.InitMargin.GetHashCode();
                if (this.MaintMargin != null)
                    hash = hash * 59 + this.MaintMargin.GetHashCode();
                if (this.SessionMargin != null)
                    hash = hash * 59 + this.SessionMargin.GetHashCode();
                if (this.TargetExcessMargin != null)
                    hash = hash * 59 + this.TargetExcessMargin.GetHashCode();
                if (this.VarMargin != null)
                    hash = hash * 59 + this.VarMargin.GetHashCode();
                if (this.RealisedPnl != null)
                    hash = hash * 59 + this.RealisedPnl.GetHashCode();
                if (this.UnrealisedPnl != null)
                    hash = hash * 59 + this.UnrealisedPnl.GetHashCode();
                if (this.IndicativeTax != null)
                    hash = hash * 59 + this.IndicativeTax.GetHashCode();
                if (this.UnrealisedProfit != null)
                    hash = hash * 59 + this.UnrealisedProfit.GetHashCode();
                if (this.SyntheticMargin != null)
                    hash = hash * 59 + this.SyntheticMargin.GetHashCode();
                if (this.WalletBalance != null)
                    hash = hash * 59 + this.WalletBalance.GetHashCode();
                if (this.MarginBalance != null)
                    hash = hash * 59 + this.MarginBalance.GetHashCode();
                if (this.MarginBalancePcnt != null)
                    hash = hash * 59 + this.MarginBalancePcnt.GetHashCode();
                if (this.MarginLeverage != null)
                    hash = hash * 59 + this.MarginLeverage.GetHashCode();
                if (this.MarginUsedPcnt != null)
                    hash = hash * 59 + this.MarginUsedPcnt.GetHashCode();
                if (this.ExcessMargin != null)
                    hash = hash * 59 + this.ExcessMargin.GetHashCode();
                if (this.ExcessMarginPcnt != null)
                    hash = hash * 59 + this.ExcessMarginPcnt.GetHashCode();
                if (this.AvailableMargin != null)
                    hash = hash * 59 + this.AvailableMargin.GetHashCode();
                if (this.WithdrawableMargin != null)
                    hash = hash * 59 + this.WithdrawableMargin.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.GrossLastValue != null)
                    hash = hash * 59 + this.GrossLastValue.GetHashCode();
                if (this.Commission != null)
                    hash = hash * 59 + this.Commission.GetHashCode();
                return hash;
            }
        }
    }

}
