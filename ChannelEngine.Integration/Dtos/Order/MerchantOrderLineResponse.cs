﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using ChannelEngine.Integration.Dtos.Enums;
using Newtonsoft.Json;

namespace ChannelEngine.Integration.Dtos.Order
{
    /// <summary>
    /// MerchantOrderLineResponse
    /// </summary>
    [DataContract(Name = "MerchantOrderLineResponse")]
    public partial class MerchantOrderLineResponse : IEquatable<MerchantOrderLineResponse>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public OrderStatusView? Status { get; set; }

        /// <summary>
        /// Gets or Sets Condition
        /// </summary>
        [DataMember(Name = "Condition", EmitDefaultValue = false)]
        public Condition? Condition { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantOrderLineResponse" /> class.
        /// </summary>
        [JsonConstructor]
        protected MerchantOrderLineResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantOrderLineResponse" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="isFulfillmentByMarketplace">Is the order fulfilled by the marketplace (amazon: FBA, bol: LVB, etc.)?..</param>
        /// <param name="gtin">Either the GTIN (EAN, ISBN, UPC etc) provided by the channel, or the the GTIN belonging to the MerchantProductNo in ChannelEngine..</param>
        /// <param name="description">The product description (or title) provided by the channel..</param>
        /// <param name="unitVat">The total amount of VAT charged over the value of a single unit of the ordered product  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering)..</param>
        /// <param name="lineTotalInclVat">The total value of the order line (quantity * unit price) including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering)..</param>
        /// <param name="lineVat">The total amount of VAT charged over the total value of the order line (quantity * unit price)  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering)..</param>
        /// <param name="originalUnitPriceInclVat">The value of a single unit of the ordered product including VAT  (in the currency in which the order was paid for, see CurrencyCode)..</param>
        /// <param name="originalUnitVat">The total amount of VAT charged over the value of a single unit of the ordered product  (in the currency in which the order was paid for, see CurrencyCode)..</param>
        /// <param name="originalLineTotalInclVat">The total value of the order line (quantity * unit price) including VAT  (in the currency in which the order was paid for, see CurrencyCode)..</param>
        /// <param name="originalLineVat">The total amount of VAT charged over the total value of the order line (quantity * unit price)  (in the currency in which the order was paid for, see CurrencyCode)..</param>
        /// <param name="originalFeeFixed">A percentage fee that is charged by the Channel for this orderline.  This fee rate is based on the currency of client  This field is optional, send 0 if not applicable..</param>
        /// <param name="bundleProductMerchantProductNo">If the product is ordered part of a bundle, this field contains the MerchantProductNo of  the product bundle..</param>
        /// <param name="jurisCode">State assigned code identifying the jurisdiction..</param>
        /// <param name="jurisName">Name of a tax jurisdiction..</param>
        /// <param name="vatRate">VAT rate of the orderline..</param>
        /// <param name="extraData">extraData.</param>
        /// <param name="channelProductNo">The unique product reference used by the channel. (required).</param>
        /// <param name="merchantProductNo">The unique product reference used by the merchant..</param>
        /// <param name="quantity">The number of items of the product. (required).</param>
        /// <param name="cancellationRequestedQuantity">The number of items for which cancellation was requested by the customer.  Some channels allow a customer to cancel an order until it has been shipped.  When an order has already been acknowledged in ChannelEngine, it can only be cancelled by creating a cancellation.  Use this field to check whether it is still possible to cancel the order. If this is the case, submit a cancellation to ChannelEngine..</param>
        /// <param name="unitPriceInclVat">The value of a single unit of the ordered product including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering). (required).</param>
        /// <param name="feeFixed">A fixed fee that is charged by the Channel for this orderline.  This fee rate is based on the currency of the Channel  This field is optional, send 0 if not applicable..</param>
        /// <param name="feeRate">A percentage fee that is charged by the Channel for this orderline.  This field is optional, send 0 if not applicable..</param>
        /// <param name="condition">condition.</param>
        /// <param name="expectedDeliveryDate">Expected delivery date from channels, empty if channels not support this value.</param>
        public MerchantOrderLineResponse(OrderStatusView? status = default(OrderStatusView?), bool isFulfillmentByMarketplace = default(bool), string gtin = default(string), string description = default(string), decimal? unitVat = default(decimal?), decimal? lineTotalInclVat = default(decimal?), decimal? lineVat = default(decimal?), decimal? originalUnitPriceInclVat = default(decimal?), decimal? originalUnitVat = default(decimal?), decimal? originalLineTotalInclVat = default(decimal?), decimal? originalLineVat = default(decimal?), decimal originalFeeFixed = default(decimal), string bundleProductMerchantProductNo = default(string), string jurisCode = default(string), string jurisName = default(string), decimal vatRate = default(decimal), List<MerchantOrderLineExtraDataResponse> extraData = default(List<MerchantOrderLineExtraDataResponse>), string channelProductNo = default(string), string merchantProductNo = default(string), int quantity = default(int), int cancellationRequestedQuantity = default(int), decimal unitPriceInclVat = default(decimal), decimal feeFixed = default(decimal), decimal feeRate = default(decimal), Condition? condition = default(Condition?), DateTime? expectedDeliveryDate = default(DateTime?))
        {
            // to ensure "channelProductNo" is required (not null)
            this.ChannelProductNo = channelProductNo ?? throw new ArgumentNullException("channelProductNo is a required property for MerchantOrderLineResponse and cannot be null");
            this.Quantity = quantity;
            this.UnitPriceInclVat = unitPriceInclVat;
            this.Status = status;
            this.IsFulfillmentByMarketplace = isFulfillmentByMarketplace;
            this.Gtin = gtin;
            this.Description = description;
            this.UnitVat = unitVat;
            this.LineTotalInclVat = lineTotalInclVat;
            this.LineVat = lineVat;
            this.OriginalUnitPriceInclVat = originalUnitPriceInclVat;
            this.OriginalUnitVat = originalUnitVat;
            this.OriginalLineTotalInclVat = originalLineTotalInclVat;
            this.OriginalLineVat = originalLineVat;
            this.OriginalFeeFixed = originalFeeFixed;
            this.BundleProductMerchantProductNo = bundleProductMerchantProductNo;
            this.JurisCode = jurisCode;
            this.JurisName = jurisName;
            this.VatRate = vatRate;
            this.ExtraData = extraData;
            this.MerchantProductNo = merchantProductNo;
            this.CancellationRequestedQuantity = cancellationRequestedQuantity;
            this.FeeFixed = feeFixed;
            this.FeeRate = feeRate;
            this.Condition = condition;
            this.ExpectedDeliveryDate = expectedDeliveryDate;
        }

        /// <summary>
        /// Is the order fulfilled by the marketplace (amazon: FBA, bol: LVB, etc.)?.
        /// </summary>
        /// <value>Is the order fulfilled by the marketplace (amazon: FBA, bol: LVB, etc.)?.</value>
        [DataMember(Name = "IsFulfillmentByMarketplace", EmitDefaultValue = true)]
        public bool IsFulfillmentByMarketplace { get; set; }

        /// <summary>
        /// Either the GTIN (EAN, ISBN, UPC etc) provided by the channel, or the the GTIN belonging to the MerchantProductNo in ChannelEngine.
        /// </summary>
        /// <value>Either the GTIN (EAN, ISBN, UPC etc) provided by the channel, or the the GTIN belonging to the MerchantProductNo in ChannelEngine.</value>
        [DataMember(Name = "Gtin", EmitDefaultValue = true)]
        public string Gtin { get; set; }

        /// <summary>
        /// The product description (or title) provided by the channel.
        /// </summary>
        /// <value>The product description (or title) provided by the channel.</value>
        [DataMember(Name = "Description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The total amount of VAT charged over the value of a single unit of the ordered product  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).
        /// </summary>
        /// <value>The total amount of VAT charged over the value of a single unit of the ordered product  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).</value>
        [DataMember(Name = "UnitVat", EmitDefaultValue = true)]
        public decimal? UnitVat { get; set; }

        /// <summary>
        /// The total value of the order line (quantity * unit price) including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).
        /// </summary>
        /// <value>The total value of the order line (quantity * unit price) including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).</value>
        [DataMember(Name = "LineTotalInclVat", EmitDefaultValue = true)]
        public decimal? LineTotalInclVat { get; set; }

        /// <summary>
        /// The total amount of VAT charged over the total value of the order line (quantity * unit price)  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).
        /// </summary>
        /// <value>The total amount of VAT charged over the total value of the order line (quantity * unit price)  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).</value>
        [DataMember(Name = "LineVat", EmitDefaultValue = true)]
        public decimal? LineVat { get; set; }

        /// <summary>
        /// The value of a single unit of the ordered product including VAT  (in the currency in which the order was paid for, see CurrencyCode).
        /// </summary>
        /// <value>The value of a single unit of the ordered product including VAT  (in the currency in which the order was paid for, see CurrencyCode).</value>
        [DataMember(Name = "OriginalUnitPriceInclVat", EmitDefaultValue = true)]
        public decimal? OriginalUnitPriceInclVat { get; set; }

        /// <summary>
        /// The total amount of VAT charged over the value of a single unit of the ordered product  (in the currency in which the order was paid for, see CurrencyCode).
        /// </summary>
        /// <value>The total amount of VAT charged over the value of a single unit of the ordered product  (in the currency in which the order was paid for, see CurrencyCode).</value>
        [DataMember(Name = "OriginalUnitVat", EmitDefaultValue = true)]
        public decimal? OriginalUnitVat { get; set; }

        /// <summary>
        /// The total value of the order line (quantity * unit price) including VAT  (in the currency in which the order was paid for, see CurrencyCode).
        /// </summary>
        /// <value>The total value of the order line (quantity * unit price) including VAT  (in the currency in which the order was paid for, see CurrencyCode).</value>
        [DataMember(Name = "OriginalLineTotalInclVat", EmitDefaultValue = true)]
        public decimal? OriginalLineTotalInclVat { get; set; }

        /// <summary>
        /// The total amount of VAT charged over the total value of the order line (quantity * unit price)  (in the currency in which the order was paid for, see CurrencyCode).
        /// </summary>
        /// <value>The total amount of VAT charged over the total value of the order line (quantity * unit price)  (in the currency in which the order was paid for, see CurrencyCode).</value>
        [DataMember(Name = "OriginalLineVat", EmitDefaultValue = true)]
        public decimal? OriginalLineVat { get; set; }

        /// <summary>
        /// A percentage fee that is charged by the Channel for this orderline.  This fee rate is based on the currency of client  This field is optional, send 0 if not applicable.
        /// </summary>
        /// <value>A percentage fee that is charged by the Channel for this orderline.  This fee rate is based on the currency of client  This field is optional, send 0 if not applicable.</value>
        [DataMember(Name = "OriginalFeeFixed", EmitDefaultValue = false)]
        public decimal OriginalFeeFixed { get; set; }

        /// <summary>
        /// If the product is ordered part of a bundle, this field contains the MerchantProductNo of  the product bundle.
        /// </summary>
        /// <value>If the product is ordered part of a bundle, this field contains the MerchantProductNo of  the product bundle.</value>
        [DataMember(Name = "BundleProductMerchantProductNo", EmitDefaultValue = true)]
        public string BundleProductMerchantProductNo { get; set; }

        /// <summary>
        /// State assigned code identifying the jurisdiction.
        /// </summary>
        /// <value>State assigned code identifying the jurisdiction.</value>
        [DataMember(Name = "JurisCode", EmitDefaultValue = true)]
        public string JurisCode { get; set; }

        /// <summary>
        /// Name of a tax jurisdiction.
        /// </summary>
        /// <value>Name of a tax jurisdiction.</value>
        [DataMember(Name = "JurisName", EmitDefaultValue = true)]
        public string JurisName { get; set; }

        /// <summary>
        /// VAT rate of the orderline.
        /// </summary>
        /// <value>VAT rate of the orderline.</value>
        [DataMember(Name = "VatRate", EmitDefaultValue = false)]
        public decimal VatRate { get; set; }

        /// <summary>
        /// Gets or Sets ExtraData
        /// </summary>
        [DataMember(Name = "ExtraData", EmitDefaultValue = true)]
        public List<MerchantOrderLineExtraDataResponse> ExtraData { get; set; }

        /// <summary>
        /// The unique product reference used by the channel.
        /// </summary>
        /// <value>The unique product reference used by the channel.</value>
        [DataMember(Name = "ChannelProductNo", IsRequired = true, EmitDefaultValue = false)]
        public string ChannelProductNo { get; set; }

        /// <summary>
        /// The unique product reference used by the merchant.
        /// </summary>
        /// <value>The unique product reference used by the merchant.</value>
        [DataMember(Name = "MerchantProductNo", EmitDefaultValue = true)]
        public string MerchantProductNo { get; set; }

        /// <summary>
        /// The number of items of the product.
        /// </summary>
        /// <value>The number of items of the product.</value>
        [DataMember(Name = "Quantity", IsRequired = true, EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// The number of items for which cancellation was requested by the customer.  Some channels allow a customer to cancel an order until it has been shipped.  When an order has already been acknowledged in ChannelEngine, it can only be cancelled by creating a cancellation.  Use this field to check whether it is still possible to cancel the order. If this is the case, submit a cancellation to ChannelEngine.
        /// </summary>
        /// <value>The number of items for which cancellation was requested by the customer.  Some channels allow a customer to cancel an order until it has been shipped.  When an order has already been acknowledged in ChannelEngine, it can only be cancelled by creating a cancellation.  Use this field to check whether it is still possible to cancel the order. If this is the case, submit a cancellation to ChannelEngine.</value>
        [DataMember(Name = "CancellationRequestedQuantity", EmitDefaultValue = false)]
        public int CancellationRequestedQuantity { get; set; }

        /// <summary>
        /// The value of a single unit of the ordered product including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).
        /// </summary>
        /// <value>The value of a single unit of the ordered product including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).</value>
        [DataMember(Name = "UnitPriceInclVat", IsRequired = true, EmitDefaultValue = false)]
        public decimal UnitPriceInclVat { get; set; }

        /// <summary>
        /// A fixed fee that is charged by the Channel for this orderline.  This fee rate is based on the currency of the Channel  This field is optional, send 0 if not applicable.
        /// </summary>
        /// <value>A fixed fee that is charged by the Channel for this orderline.  This fee rate is based on the currency of the Channel  This field is optional, send 0 if not applicable.</value>
        [DataMember(Name = "FeeFixed", EmitDefaultValue = false)]
        public decimal FeeFixed { get; set; }

        /// <summary>
        /// A percentage fee that is charged by the Channel for this orderline.  This field is optional, send 0 if not applicable.
        /// </summary>
        /// <value>A percentage fee that is charged by the Channel for this orderline.  This field is optional, send 0 if not applicable.</value>
        [DataMember(Name = "FeeRate", EmitDefaultValue = false)]
        public decimal FeeRate { get; set; }

        /// <summary>
        /// Expected delivery date from channels, empty if channels not support this value
        /// </summary>
        /// <value>Expected delivery date from channels, empty if channels not support this value</value>
        [DataMember(Name = "ExpectedDeliveryDate", EmitDefaultValue = true)]
        public DateTime? ExpectedDeliveryDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantOrderLineResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IsFulfillmentByMarketplace: ").Append(IsFulfillmentByMarketplace).Append("\n");
            sb.Append("  Gtin: ").Append(Gtin).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  UnitVat: ").Append(UnitVat).Append("\n");
            sb.Append("  LineTotalInclVat: ").Append(LineTotalInclVat).Append("\n");
            sb.Append("  LineVat: ").Append(LineVat).Append("\n");
            sb.Append("  OriginalUnitPriceInclVat: ").Append(OriginalUnitPriceInclVat).Append("\n");
            sb.Append("  OriginalUnitVat: ").Append(OriginalUnitVat).Append("\n");
            sb.Append("  OriginalLineTotalInclVat: ").Append(OriginalLineTotalInclVat).Append("\n");
            sb.Append("  OriginalLineVat: ").Append(OriginalLineVat).Append("\n");
            sb.Append("  OriginalFeeFixed: ").Append(OriginalFeeFixed).Append("\n");
            sb.Append("  BundleProductMerchantProductNo: ").Append(BundleProductMerchantProductNo).Append("\n");
            sb.Append("  JurisCode: ").Append(JurisCode).Append("\n");
            sb.Append("  JurisName: ").Append(JurisName).Append("\n");
            sb.Append("  VatRate: ").Append(VatRate).Append("\n");
            sb.Append("  ExtraData: ").Append(ExtraData).Append("\n");
            sb.Append("  ChannelProductNo: ").Append(ChannelProductNo).Append("\n");
            sb.Append("  MerchantProductNo: ").Append(MerchantProductNo).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  CancellationRequestedQuantity: ").Append(CancellationRequestedQuantity).Append("\n");
            sb.Append("  UnitPriceInclVat: ").Append(UnitPriceInclVat).Append("\n");
            sb.Append("  FeeFixed: ").Append(FeeFixed).Append("\n");
            sb.Append("  FeeRate: ").Append(FeeRate).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  ExpectedDeliveryDate: ").Append(ExpectedDeliveryDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MerchantOrderLineResponse);
        }

        /// <summary>
        /// Returns true if MerchantOrderLineResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantOrderLineResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantOrderLineResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) &&
                (
                    this.IsFulfillmentByMarketplace == input.IsFulfillmentByMarketplace ||
                    this.IsFulfillmentByMarketplace.Equals(input.IsFulfillmentByMarketplace)
                ) &&
                (
                    this.Gtin == input.Gtin ||
                    (this.Gtin != null &&
                    this.Gtin.Equals(input.Gtin))
                ) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) &&
                (
                    this.UnitVat == input.UnitVat ||
                    (this.UnitVat != null &&
                    this.UnitVat.Equals(input.UnitVat))
                ) &&
                (
                    this.LineTotalInclVat == input.LineTotalInclVat ||
                    (this.LineTotalInclVat != null &&
                    this.LineTotalInclVat.Equals(input.LineTotalInclVat))
                ) &&
                (
                    this.LineVat == input.LineVat ||
                    (this.LineVat != null &&
                    this.LineVat.Equals(input.LineVat))
                ) &&
                (
                    this.OriginalUnitPriceInclVat == input.OriginalUnitPriceInclVat ||
                    (this.OriginalUnitPriceInclVat != null &&
                    this.OriginalUnitPriceInclVat.Equals(input.OriginalUnitPriceInclVat))
                ) &&
                (
                    this.OriginalUnitVat == input.OriginalUnitVat ||
                    (this.OriginalUnitVat != null &&
                    this.OriginalUnitVat.Equals(input.OriginalUnitVat))
                ) &&
                (
                    this.OriginalLineTotalInclVat == input.OriginalLineTotalInclVat ||
                    (this.OriginalLineTotalInclVat != null &&
                    this.OriginalLineTotalInclVat.Equals(input.OriginalLineTotalInclVat))
                ) &&
                (
                    this.OriginalLineVat == input.OriginalLineVat ||
                    (this.OriginalLineVat != null &&
                    this.OriginalLineVat.Equals(input.OriginalLineVat))
                ) &&
                (
                    this.OriginalFeeFixed == input.OriginalFeeFixed ||
                    this.OriginalFeeFixed.Equals(input.OriginalFeeFixed)
                ) &&
                (
                    this.BundleProductMerchantProductNo == input.BundleProductMerchantProductNo ||
                    (this.BundleProductMerchantProductNo != null &&
                    this.BundleProductMerchantProductNo.Equals(input.BundleProductMerchantProductNo))
                ) &&
                (
                    this.JurisCode == input.JurisCode ||
                    (this.JurisCode != null &&
                    this.JurisCode.Equals(input.JurisCode))
                ) &&
                (
                    this.JurisName == input.JurisName ||
                    (this.JurisName != null &&
                    this.JurisName.Equals(input.JurisName))
                ) &&
                (
                    this.VatRate == input.VatRate ||
                    this.VatRate.Equals(input.VatRate)
                ) &&
                (
                    this.ExtraData == input.ExtraData ||
                    this.ExtraData != null &&
                    input.ExtraData != null &&
                    this.ExtraData.SequenceEqual(input.ExtraData)
                ) &&
                (
                    this.ChannelProductNo == input.ChannelProductNo ||
                    (this.ChannelProductNo != null &&
                    this.ChannelProductNo.Equals(input.ChannelProductNo))
                ) &&
                (
                    this.MerchantProductNo == input.MerchantProductNo ||
                    (this.MerchantProductNo != null &&
                    this.MerchantProductNo.Equals(input.MerchantProductNo))
                ) &&
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) &&
                (
                    this.CancellationRequestedQuantity == input.CancellationRequestedQuantity ||
                    this.CancellationRequestedQuantity.Equals(input.CancellationRequestedQuantity)
                ) &&
                (
                    this.UnitPriceInclVat == input.UnitPriceInclVat ||
                    this.UnitPriceInclVat.Equals(input.UnitPriceInclVat)
                ) &&
                (
                    this.FeeFixed == input.FeeFixed ||
                    this.FeeFixed.Equals(input.FeeFixed)
                ) &&
                (
                    this.FeeRate == input.FeeRate ||
                    this.FeeRate.Equals(input.FeeRate)
                ) &&
                (
                    this.Condition == input.Condition ||
                    this.Condition.Equals(input.Condition)
                ) &&
                (
                    this.ExpectedDeliveryDate == input.ExpectedDeliveryDate ||
                    (this.ExpectedDeliveryDate != null &&
                    this.ExpectedDeliveryDate.Equals(input.ExpectedDeliveryDate))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.IsFulfillmentByMarketplace.GetHashCode();
                if (this.Gtin != null)
                    hashCode = hashCode * 59 + this.Gtin.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.UnitVat != null)
                    hashCode = hashCode * 59 + this.UnitVat.GetHashCode();
                if (this.LineTotalInclVat != null)
                    hashCode = hashCode * 59 + this.LineTotalInclVat.GetHashCode();
                if (this.LineVat != null)
                    hashCode = hashCode * 59 + this.LineVat.GetHashCode();
                if (this.OriginalUnitPriceInclVat != null)
                    hashCode = hashCode * 59 + this.OriginalUnitPriceInclVat.GetHashCode();
                if (this.OriginalUnitVat != null)
                    hashCode = hashCode * 59 + this.OriginalUnitVat.GetHashCode();
                if (this.OriginalLineTotalInclVat != null)
                    hashCode = hashCode * 59 + this.OriginalLineTotalInclVat.GetHashCode();
                if (this.OriginalLineVat != null)
                    hashCode = hashCode * 59 + this.OriginalLineVat.GetHashCode();
                hashCode = hashCode * 59 + this.OriginalFeeFixed.GetHashCode();
                if (this.BundleProductMerchantProductNo != null)
                    hashCode = hashCode * 59 + this.BundleProductMerchantProductNo.GetHashCode();
                if (this.JurisCode != null)
                    hashCode = hashCode * 59 + this.JurisCode.GetHashCode();
                if (this.JurisName != null)
                    hashCode = hashCode * 59 + this.JurisName.GetHashCode();
                hashCode = hashCode * 59 + this.VatRate.GetHashCode();
                if (this.ExtraData != null)
                    hashCode = hashCode * 59 + this.ExtraData.GetHashCode();
                if (this.ChannelProductNo != null)
                    hashCode = hashCode * 59 + this.ChannelProductNo.GetHashCode();
                if (this.MerchantProductNo != null)
                    hashCode = hashCode * 59 + this.MerchantProductNo.GetHashCode();
                hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                hashCode = hashCode * 59 + this.CancellationRequestedQuantity.GetHashCode();
                hashCode = hashCode * 59 + this.UnitPriceInclVat.GetHashCode();
                hashCode = hashCode * 59 + this.FeeFixed.GetHashCode();
                hashCode = hashCode * 59 + this.FeeRate.GetHashCode();
                hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.ExpectedDeliveryDate != null)
                    hashCode = hashCode * 59 + this.ExpectedDeliveryDate.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // ChannelProductNo (string) maxLength
            if (this.ChannelProductNo != null && this.ChannelProductNo.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ChannelProductNo, length must be less than 60.", new[] { "ChannelProductNo" });
            }

            // ChannelProductNo (string) minLength
            if (this.ChannelProductNo != null && this.ChannelProductNo.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ChannelProductNo, length must be greater than 0.", new[] { "ChannelProductNo" });
            }

            // MerchantProductNo (string) maxLength
            if (this.MerchantProductNo != null && this.MerchantProductNo.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantProductNo, length must be less than 50.", new[] { "MerchantProductNo" });
            }

            // MerchantProductNo (string) minLength
            if (this.MerchantProductNo != null && this.MerchantProductNo.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantProductNo, length must be greater than 0.", new[] { "MerchantProductNo" });
            }

            // Quantity (int) minimum
            if (this.Quantity < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Quantity, must be a value greater than or equal to 0.", new[] { "Quantity" });
            }

            // CancellationRequestedQuantity (int) minimum
            if (this.CancellationRequestedQuantity < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CancellationRequestedQuantity, must be a value greater than or equal to 0.", new[] { "CancellationRequestedQuantity" });
            }

            // UnitPriceInclVat (decimal) minimum
            if (this.UnitPriceInclVat < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnitPriceInclVat, must be a value greater than or equal to 0.", new[] { "UnitPriceInclVat" });
            }

            // FeeFixed (decimal) minimum
            if (this.FeeFixed < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FeeFixed, must be a value greater than or equal to 0.", new[] { "FeeFixed" });
            }

            // FeeRate (decimal) minimum
            if (this.FeeRate < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FeeRate, must be a value greater than or equal to 0.", new[] { "FeeRate" });
            }

            yield break;
        }
    }
}