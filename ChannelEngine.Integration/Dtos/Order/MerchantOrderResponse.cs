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
    /// MerchantOrderResponse
    /// </summary>
    [DataContract(Name = "MerchantOrderResponse")]
    public partial class MerchantOrderResponse : IEquatable<MerchantOrderResponse>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ChannelOrderSupport
        /// </summary>
        [DataMember(Name = "ChannelOrderSupport", EmitDefaultValue = false)]
        public OrderSupport? ChannelOrderSupport { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public OrderStatusView? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantOrderResponse" /> class.
        /// </summary>
        [JsonConstructor]
        protected MerchantOrderResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantOrderResponse" /> class.
        /// </summary>
        /// <param name="id">The unique identifier used by ChannelEngine. This identifier does  not have to be saved. It should only be used in a call to acknowledge the order..</param>
        /// <param name="channelName">The name of the channel for this specific environment/account..</param>
        /// <param name="channelId">The unique ID of the channel for this specific environment/account..</param>
        /// <param name="globalChannelName">The name of the channel across all of ChannelEngine..</param>
        /// <param name="globalChannelId">The unique ID of the channel across all of ChannelEngine..</param>
        /// <param name="channelOrderSupport">channelOrderSupport.</param>
        /// <param name="channelOrderNo">The order reference used by the channel.  This number is not guaranteed to be unique accross all orders,  because different channels can use the same order number format..</param>
        /// <param name="status">status.</param>
        /// <param name="isBusinessOrder">Indicating whether the order is a business order..</param>
        /// <param name="createdAt">The date the order was created in ChannelEngine..</param>
        /// <param name="updatedAt">The date the order was last updated in ChannelEngine..</param>
        /// <param name="merchantComment">The optional comment a merchant can add to an order..</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="shippingAddress">shippingAddress.</param>
        /// <param name="subTotalInclVat">The total value of the order lines including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering)..</param>
        /// <param name="subTotalVat">The total amount of VAT charged over the order lines  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering)..</param>
        /// <param name="shippingCostsVat">The total amount of VAT charged over the shipping fee  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering)..</param>
        /// <param name="totalInclVat">The total value of the order including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering)..</param>
        /// <param name="totalVat">The total amount of VAT charged over the total value of te order  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering)..</param>
        /// <param name="originalSubTotalInclVat">The total value of the order lines including VAT  (in the currency in which the order was paid for, see CurrencyCode)..</param>
        /// <param name="originalSubTotalVat">The total amount of VAT charged over the order lines  (in the currency in which the order was paid for, see CurrencyCode)..</param>
        /// <param name="originalShippingCostsInclVat">The shipping fee including VAT  (in the currency in which the order was paid for, see CurrencyCode)..</param>
        /// <param name="originalShippingCostsVat">The total amount of VAT charged over the shipping fee  (in the currency in which the order was paid for, see CurrencyCode)..</param>
        /// <param name="originalTotalInclVat">The total value of the order including VAT  (in the currency in which the order was paid for, see CurrencyCode)..</param>
        /// <param name="originalTotalVat">The total amount of VAT charged over the total value of te order  (in the currency in which the order was paid for, see CurrencyCode)..</param>
        /// <param name="lines">lines.</param>
        /// <param name="phone">The customer&#39;s telephone number..</param>
        /// <param name="email">The customer&#39;s email. (required).</param>
        /// <param name="companyRegistrationNo">Optional. A company&#39;s chamber of commerce number..</param>
        /// <param name="vatNo">Optional. A company&#39;s VAT number..</param>
        /// <param name="paymentMethod">The payment method used on the order..</param>
        /// <param name="paymentReferenceNo">Reference or transaction id for the payment.</param>
        /// <param name="shippingCostsInclVat">The shipping fee including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering). (required).</param>
        /// <param name="currencyCode">The currency code for the amounts of the order. (required).</param>
        /// <param name="orderDate">The date the order was created at the channel. (required).</param>
        /// <param name="channelCustomerNo">The unique customer reference used by the channel..</param>
        /// <param name="extraData">Extra data on the order..</param>
        public MerchantOrderResponse(int id = default(int), string channelName = default(string), int? channelId = default(int?), string globalChannelName = default(string), int? globalChannelId = default(int?), OrderSupport? channelOrderSupport = default(OrderSupport?), string channelOrderNo = default(string), OrderStatusView? status = default(OrderStatusView?), bool isBusinessOrder = default(bool), DateTime? createdAt = default(DateTime?), DateTime? updatedAt = default(DateTime?), string merchantComment = default(string), MerchantAddressResponse billingAddress = default(MerchantAddressResponse), MerchantAddressResponse shippingAddress = default(MerchantAddressResponse), decimal? subTotalInclVat = default(decimal?), decimal? subTotalVat = default(decimal?), decimal? shippingCostsVat = default(decimal?), decimal totalInclVat = default(decimal), decimal? totalVat = default(decimal?), decimal? originalSubTotalInclVat = default(decimal?), decimal? originalSubTotalVat = default(decimal?), decimal? originalShippingCostsInclVat = default(decimal?), decimal? originalShippingCostsVat = default(decimal?), decimal? originalTotalInclVat = default(decimal?), decimal? originalTotalVat = default(decimal?), List<MerchantOrderLineResponse> lines = default(List<MerchantOrderLineResponse>), string phone = default(string), string email = default(string), string companyRegistrationNo = default(string), string vatNo = default(string), string paymentMethod = default(string), string paymentReferenceNo = default(string), decimal shippingCostsInclVat = default(decimal), string currencyCode = default(string), DateTime orderDate = default(DateTime), string channelCustomerNo = default(string), Dictionary<string, string> extraData = default(Dictionary<string, string>))
        {
            // to ensure "email" is required (not null)
            this.Email = email ?? throw new ArgumentNullException("email is a required property for MerchantOrderResponse and cannot be null");
            this.ShippingCostsInclVat = shippingCostsInclVat;
            // to ensure "currencyCode" is required (not null)
            this.CurrencyCode = currencyCode ?? throw new ArgumentNullException("currencyCode is a required property for MerchantOrderResponse and cannot be null");
            this.OrderDate = orderDate;
            this.Id = id;
            this.ChannelName = channelName;
            this.ChannelId = channelId;
            this.GlobalChannelName = globalChannelName;
            this.GlobalChannelId = globalChannelId;
            this.ChannelOrderSupport = channelOrderSupport;
            this.ChannelOrderNo = channelOrderNo;
            this.Status = status;
            this.IsBusinessOrder = isBusinessOrder;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.MerchantComment = merchantComment;
            this.BillingAddress = billingAddress;
            this.ShippingAddress = shippingAddress;
            this.SubTotalInclVat = subTotalInclVat;
            this.SubTotalVat = subTotalVat;
            this.ShippingCostsVat = shippingCostsVat;
            this.TotalInclVat = totalInclVat;
            this.TotalVat = totalVat;
            this.OriginalSubTotalInclVat = originalSubTotalInclVat;
            this.OriginalSubTotalVat = originalSubTotalVat;
            this.OriginalShippingCostsInclVat = originalShippingCostsInclVat;
            this.OriginalShippingCostsVat = originalShippingCostsVat;
            this.OriginalTotalInclVat = originalTotalInclVat;
            this.OriginalTotalVat = originalTotalVat;
            this.Lines = lines;
            this.Phone = phone;
            this.CompanyRegistrationNo = companyRegistrationNo;
            this.VatNo = vatNo;
            this.PaymentMethod = paymentMethod;
            this.PaymentReferenceNo = paymentReferenceNo;
            this.ChannelCustomerNo = channelCustomerNo;
            this.ExtraData = extraData;
        }

        /// <summary>
        /// The unique identifier used by ChannelEngine. This identifier does  not have to be saved. It should only be used in a call to acknowledge the order.
        /// </summary>
        /// <value>The unique identifier used by ChannelEngine. This identifier does  not have to be saved. It should only be used in a call to acknowledge the order.</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The name of the channel for this specific environment/account.
        /// </summary>
        /// <value>The name of the channel for this specific environment/account.</value>
        [DataMember(Name = "ChannelName", EmitDefaultValue = true)]
        public string ChannelName { get; set; }

        /// <summary>
        /// The unique ID of the channel for this specific environment/account.
        /// </summary>
        /// <value>The unique ID of the channel for this specific environment/account.</value>
        [DataMember(Name = "ChannelId", EmitDefaultValue = true)]
        public int? ChannelId { get; set; }

        /// <summary>
        /// The name of the channel across all of ChannelEngine.
        /// </summary>
        /// <value>The name of the channel across all of ChannelEngine.</value>
        [DataMember(Name = "GlobalChannelName", EmitDefaultValue = true)]
        public string GlobalChannelName { get; set; }

        /// <summary>
        /// The unique ID of the channel across all of ChannelEngine.
        /// </summary>
        /// <value>The unique ID of the channel across all of ChannelEngine.</value>
        [DataMember(Name = "GlobalChannelId", EmitDefaultValue = true)]
        public int? GlobalChannelId { get; set; }

        /// <summary>
        /// The order reference used by the channel.  This number is not guaranteed to be unique accross all orders,  because different channels can use the same order number format.
        /// </summary>
        /// <value>The order reference used by the channel.  This number is not guaranteed to be unique accross all orders,  because different channels can use the same order number format.</value>
        [DataMember(Name = "ChannelOrderNo", EmitDefaultValue = true)]
        public string ChannelOrderNo { get; set; }

        /// <summary>
        /// Indicating whether the order is a business order.
        /// </summary>
        /// <value>Indicating whether the order is a business order.</value>
        [DataMember(Name = "IsBusinessOrder", EmitDefaultValue = true)]
        public bool IsBusinessOrder { get; set; }

        /// <summary>
        /// The date the order was created in ChannelEngine.
        /// </summary>
        /// <value>The date the order was created in ChannelEngine.</value>
        [DataMember(Name = "CreatedAt", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The date the order was last updated in ChannelEngine.
        /// </summary>
        /// <value>The date the order was last updated in ChannelEngine.</value>
        [DataMember(Name = "UpdatedAt", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The optional comment a merchant can add to an order.
        /// </summary>
        /// <value>The optional comment a merchant can add to an order.</value>
        [DataMember(Name = "MerchantComment", EmitDefaultValue = true)]
        public string MerchantComment { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "BillingAddress", EmitDefaultValue = false)]
        public MerchantAddressResponse BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name = "ShippingAddress", EmitDefaultValue = false)]
        public MerchantAddressResponse ShippingAddress { get; set; }

        /// <summary>
        /// The total value of the order lines including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).
        /// </summary>
        /// <value>The total value of the order lines including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).</value>
        [DataMember(Name = "SubTotalInclVat", EmitDefaultValue = true)]
        public decimal? SubTotalInclVat { get; set; }

        /// <summary>
        /// The total amount of VAT charged over the order lines  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).
        /// </summary>
        /// <value>The total amount of VAT charged over the order lines  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).</value>
        [DataMember(Name = "SubTotalVat", EmitDefaultValue = true)]
        public decimal? SubTotalVat { get; set; }

        /// <summary>
        /// The total amount of VAT charged over the shipping fee  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).
        /// </summary>
        /// <value>The total amount of VAT charged over the shipping fee  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).</value>
        [DataMember(Name = "ShippingCostsVat", EmitDefaultValue = true)]
        public decimal? ShippingCostsVat { get; set; }

        /// <summary>
        /// The total value of the order including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).
        /// </summary>
        /// <value>The total value of the order including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).</value>
        [DataMember(Name = "TotalInclVat", EmitDefaultValue = false)]
        public decimal TotalInclVat { get; set; }

        /// <summary>
        /// The total amount of VAT charged over the total value of te order  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).
        /// </summary>
        /// <value>The total amount of VAT charged over the total value of te order  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).</value>
        [DataMember(Name = "TotalVat", EmitDefaultValue = true)]
        public decimal? TotalVat { get; set; }

        /// <summary>
        /// The total value of the order lines including VAT  (in the currency in which the order was paid for, see CurrencyCode).
        /// </summary>
        /// <value>The total value of the order lines including VAT  (in the currency in which the order was paid for, see CurrencyCode).</value>
        [DataMember(Name = "OriginalSubTotalInclVat", EmitDefaultValue = true)]
        public decimal? OriginalSubTotalInclVat { get; set; }

        /// <summary>
        /// The total amount of VAT charged over the order lines  (in the currency in which the order was paid for, see CurrencyCode).
        /// </summary>
        /// <value>The total amount of VAT charged over the order lines  (in the currency in which the order was paid for, see CurrencyCode).</value>
        [DataMember(Name = "OriginalSubTotalVat", EmitDefaultValue = true)]
        public decimal? OriginalSubTotalVat { get; set; }

        /// <summary>
        /// The shipping fee including VAT  (in the currency in which the order was paid for, see CurrencyCode).
        /// </summary>
        /// <value>The shipping fee including VAT  (in the currency in which the order was paid for, see CurrencyCode).</value>
        [DataMember(Name = "OriginalShippingCostsInclVat", EmitDefaultValue = true)]
        public decimal? OriginalShippingCostsInclVat { get; set; }

        /// <summary>
        /// The total amount of VAT charged over the shipping fee  (in the currency in which the order was paid for, see CurrencyCode).
        /// </summary>
        /// <value>The total amount of VAT charged over the shipping fee  (in the currency in which the order was paid for, see CurrencyCode).</value>
        [DataMember(Name = "OriginalShippingCostsVat", EmitDefaultValue = true)]
        public decimal? OriginalShippingCostsVat { get; set; }

        /// <summary>
        /// The total value of the order including VAT  (in the currency in which the order was paid for, see CurrencyCode).
        /// </summary>
        /// <value>The total value of the order including VAT  (in the currency in which the order was paid for, see CurrencyCode).</value>
        [DataMember(Name = "OriginalTotalInclVat", EmitDefaultValue = true)]
        public decimal? OriginalTotalInclVat { get; set; }

        /// <summary>
        /// The total amount of VAT charged over the total value of te order  (in the currency in which the order was paid for, see CurrencyCode).
        /// </summary>
        /// <value>The total amount of VAT charged over the total value of te order  (in the currency in which the order was paid for, see CurrencyCode).</value>
        [DataMember(Name = "OriginalTotalVat", EmitDefaultValue = true)]
        public decimal? OriginalTotalVat { get; set; }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name = "Lines", EmitDefaultValue = true)]
        public List<MerchantOrderLineResponse> Lines { get; set; }

        /// <summary>
        /// The customer&#39;s telephone number.
        /// </summary>
        /// <value>The customer&#39;s telephone number.</value>
        [DataMember(Name = "Phone", EmitDefaultValue = true)]
        public string Phone { get; set; }

        /// <summary>
        /// The customer&#39;s email.
        /// </summary>
        /// <value>The customer&#39;s email.</value>
        [DataMember(Name = "Email", IsRequired = true, EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Optional. A company&#39;s chamber of commerce number.
        /// </summary>
        /// <value>Optional. A company&#39;s chamber of commerce number.</value>
        [DataMember(Name = "CompanyRegistrationNo", EmitDefaultValue = true)]
        public string CompanyRegistrationNo { get; set; }

        /// <summary>
        /// Optional. A company&#39;s VAT number.
        /// </summary>
        /// <value>Optional. A company&#39;s VAT number.</value>
        [DataMember(Name = "VatNo", EmitDefaultValue = true)]
        public string VatNo { get; set; }

        /// <summary>
        /// The payment method used on the order.
        /// </summary>
        /// <value>The payment method used on the order.</value>
        [DataMember(Name = "PaymentMethod", EmitDefaultValue = true)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Reference or transaction id for the payment
        /// </summary>
        /// <value>Reference or transaction id for the payment</value>
        [DataMember(Name = "PaymentReferenceNo", EmitDefaultValue = true)]
        public string PaymentReferenceNo { get; set; }

        /// <summary>
        /// The shipping fee including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).
        /// </summary>
        /// <value>The shipping fee including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).</value>
        [DataMember(Name = "ShippingCostsInclVat", IsRequired = true, EmitDefaultValue = false)]
        public decimal ShippingCostsInclVat { get; set; }

        /// <summary>
        /// The currency code for the amounts of the order.
        /// </summary>
        /// <value>The currency code for the amounts of the order.</value>
        [DataMember(Name = "CurrencyCode", IsRequired = true, EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The date the order was created at the channel.
        /// </summary>
        /// <value>The date the order was created at the channel.</value>
        [DataMember(Name = "OrderDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// The unique customer reference used by the channel.
        /// </summary>
        /// <value>The unique customer reference used by the channel.</value>
        [DataMember(Name = "ChannelCustomerNo", EmitDefaultValue = true)]
        public string ChannelCustomerNo { get; set; }

        /// <summary>
        /// Extra data on the order.
        /// </summary>
        /// <value>Extra data on the order.</value>
        [DataMember(Name = "ExtraData", EmitDefaultValue = true)]
        public Dictionary<string, string> ExtraData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantOrderResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ChannelName: ").Append(ChannelName).Append("\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  GlobalChannelName: ").Append(GlobalChannelName).Append("\n");
            sb.Append("  GlobalChannelId: ").Append(GlobalChannelId).Append("\n");
            sb.Append("  ChannelOrderSupport: ").Append(ChannelOrderSupport).Append("\n");
            sb.Append("  ChannelOrderNo: ").Append(ChannelOrderNo).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IsBusinessOrder: ").Append(IsBusinessOrder).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  MerchantComment: ").Append(MerchantComment).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  SubTotalInclVat: ").Append(SubTotalInclVat).Append("\n");
            sb.Append("  SubTotalVat: ").Append(SubTotalVat).Append("\n");
            sb.Append("  ShippingCostsVat: ").Append(ShippingCostsVat).Append("\n");
            sb.Append("  TotalInclVat: ").Append(TotalInclVat).Append("\n");
            sb.Append("  TotalVat: ").Append(TotalVat).Append("\n");
            sb.Append("  OriginalSubTotalInclVat: ").Append(OriginalSubTotalInclVat).Append("\n");
            sb.Append("  OriginalSubTotalVat: ").Append(OriginalSubTotalVat).Append("\n");
            sb.Append("  OriginalShippingCostsInclVat: ").Append(OriginalShippingCostsInclVat).Append("\n");
            sb.Append("  OriginalShippingCostsVat: ").Append(OriginalShippingCostsVat).Append("\n");
            sb.Append("  OriginalTotalInclVat: ").Append(OriginalTotalInclVat).Append("\n");
            sb.Append("  OriginalTotalVat: ").Append(OriginalTotalVat).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  CompanyRegistrationNo: ").Append(CompanyRegistrationNo).Append("\n");
            sb.Append("  VatNo: ").Append(VatNo).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  PaymentReferenceNo: ").Append(PaymentReferenceNo).Append("\n");
            sb.Append("  ShippingCostsInclVat: ").Append(ShippingCostsInclVat).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  OrderDate: ").Append(OrderDate).Append("\n");
            sb.Append("  ChannelCustomerNo: ").Append(ChannelCustomerNo).Append("\n");
            sb.Append("  ExtraData: ").Append(ExtraData).Append("\n");
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
            return this.Equals(input as MerchantOrderResponse);
        }

        /// <summary>
        /// Returns true if MerchantOrderResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantOrderResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantOrderResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) &&
                (
                    this.ChannelName == input.ChannelName ||
                    (this.ChannelName != null &&
                    this.ChannelName.Equals(input.ChannelName))
                ) &&
                (
                    this.ChannelId == input.ChannelId ||
                    (this.ChannelId != null &&
                    this.ChannelId.Equals(input.ChannelId))
                ) &&
                (
                    this.GlobalChannelName == input.GlobalChannelName ||
                    (this.GlobalChannelName != null &&
                    this.GlobalChannelName.Equals(input.GlobalChannelName))
                ) &&
                (
                    this.GlobalChannelId == input.GlobalChannelId ||
                    (this.GlobalChannelId != null &&
                    this.GlobalChannelId.Equals(input.GlobalChannelId))
                ) &&
                (
                    this.ChannelOrderSupport == input.ChannelOrderSupport ||
                    this.ChannelOrderSupport.Equals(input.ChannelOrderSupport)
                ) &&
                (
                    this.ChannelOrderNo == input.ChannelOrderNo ||
                    (this.ChannelOrderNo != null &&
                    this.ChannelOrderNo.Equals(input.ChannelOrderNo))
                ) &&
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) &&
                (
                    this.IsBusinessOrder == input.IsBusinessOrder ||
                    this.IsBusinessOrder.Equals(input.IsBusinessOrder)
                ) &&
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) &&
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) &&
                (
                    this.MerchantComment == input.MerchantComment ||
                    (this.MerchantComment != null &&
                    this.MerchantComment.Equals(input.MerchantComment))
                ) &&
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) &&
                (
                    this.ShippingAddress == input.ShippingAddress ||
                    (this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(input.ShippingAddress))
                ) &&
                (
                    this.SubTotalInclVat == input.SubTotalInclVat ||
                    (this.SubTotalInclVat != null &&
                    this.SubTotalInclVat.Equals(input.SubTotalInclVat))
                ) &&
                (
                    this.SubTotalVat == input.SubTotalVat ||
                    (this.SubTotalVat != null &&
                    this.SubTotalVat.Equals(input.SubTotalVat))
                ) &&
                (
                    this.ShippingCostsVat == input.ShippingCostsVat ||
                    (this.ShippingCostsVat != null &&
                    this.ShippingCostsVat.Equals(input.ShippingCostsVat))
                ) &&
                (
                    this.TotalInclVat == input.TotalInclVat ||
                    this.TotalInclVat.Equals(input.TotalInclVat)
                ) &&
                (
                    this.TotalVat == input.TotalVat ||
                    (this.TotalVat != null &&
                    this.TotalVat.Equals(input.TotalVat))
                ) &&
                (
                    this.OriginalSubTotalInclVat == input.OriginalSubTotalInclVat ||
                    (this.OriginalSubTotalInclVat != null &&
                    this.OriginalSubTotalInclVat.Equals(input.OriginalSubTotalInclVat))
                ) &&
                (
                    this.OriginalSubTotalVat == input.OriginalSubTotalVat ||
                    (this.OriginalSubTotalVat != null &&
                    this.OriginalSubTotalVat.Equals(input.OriginalSubTotalVat))
                ) &&
                (
                    this.OriginalShippingCostsInclVat == input.OriginalShippingCostsInclVat ||
                    (this.OriginalShippingCostsInclVat != null &&
                    this.OriginalShippingCostsInclVat.Equals(input.OriginalShippingCostsInclVat))
                ) &&
                (
                    this.OriginalShippingCostsVat == input.OriginalShippingCostsVat ||
                    (this.OriginalShippingCostsVat != null &&
                    this.OriginalShippingCostsVat.Equals(input.OriginalShippingCostsVat))
                ) &&
                (
                    this.OriginalTotalInclVat == input.OriginalTotalInclVat ||
                    (this.OriginalTotalInclVat != null &&
                    this.OriginalTotalInclVat.Equals(input.OriginalTotalInclVat))
                ) &&
                (
                    this.OriginalTotalVat == input.OriginalTotalVat ||
                    (this.OriginalTotalVat != null &&
                    this.OriginalTotalVat.Equals(input.OriginalTotalVat))
                ) &&
                (
                    this.Lines == input.Lines ||
                    this.Lines != null &&
                    input.Lines != null &&
                    this.Lines.SequenceEqual(input.Lines)
                ) &&
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) &&
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) &&
                (
                    this.CompanyRegistrationNo == input.CompanyRegistrationNo ||
                    (this.CompanyRegistrationNo != null &&
                    this.CompanyRegistrationNo.Equals(input.CompanyRegistrationNo))
                ) &&
                (
                    this.VatNo == input.VatNo ||
                    (this.VatNo != null &&
                    this.VatNo.Equals(input.VatNo))
                ) &&
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) &&
                (
                    this.PaymentReferenceNo == input.PaymentReferenceNo ||
                    (this.PaymentReferenceNo != null &&
                    this.PaymentReferenceNo.Equals(input.PaymentReferenceNo))
                ) &&
                (
                    this.ShippingCostsInclVat == input.ShippingCostsInclVat ||
                    this.ShippingCostsInclVat.Equals(input.ShippingCostsInclVat)
                ) &&
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) &&
                (
                    this.OrderDate == input.OrderDate ||
                    (this.OrderDate != null &&
                    this.OrderDate.Equals(input.OrderDate))
                ) &&
                (
                    this.ChannelCustomerNo == input.ChannelCustomerNo ||
                    (this.ChannelCustomerNo != null &&
                    this.ChannelCustomerNo.Equals(input.ChannelCustomerNo))
                ) &&
                (
                    this.ExtraData == input.ExtraData ||
                    this.ExtraData != null &&
                    input.ExtraData != null &&
                    this.ExtraData.SequenceEqual(input.ExtraData)
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ChannelName != null)
                    hashCode = hashCode * 59 + this.ChannelName.GetHashCode();
                if (this.ChannelId != null)
                    hashCode = hashCode * 59 + this.ChannelId.GetHashCode();
                if (this.GlobalChannelName != null)
                    hashCode = hashCode * 59 + this.GlobalChannelName.GetHashCode();
                if (this.GlobalChannelId != null)
                    hashCode = hashCode * 59 + this.GlobalChannelId.GetHashCode();
                hashCode = hashCode * 59 + this.ChannelOrderSupport.GetHashCode();
                if (this.ChannelOrderNo != null)
                    hashCode = hashCode * 59 + this.ChannelOrderNo.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.IsBusinessOrder.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.MerchantComment != null)
                    hashCode = hashCode * 59 + this.MerchantComment.GetHashCode();
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.ShippingAddress != null)
                    hashCode = hashCode * 59 + this.ShippingAddress.GetHashCode();
                if (this.SubTotalInclVat != null)
                    hashCode = hashCode * 59 + this.SubTotalInclVat.GetHashCode();
                if (this.SubTotalVat != null)
                    hashCode = hashCode * 59 + this.SubTotalVat.GetHashCode();
                if (this.ShippingCostsVat != null)
                    hashCode = hashCode * 59 + this.ShippingCostsVat.GetHashCode();
                hashCode = hashCode * 59 + this.TotalInclVat.GetHashCode();
                if (this.TotalVat != null)
                    hashCode = hashCode * 59 + this.TotalVat.GetHashCode();
                if (this.OriginalSubTotalInclVat != null)
                    hashCode = hashCode * 59 + this.OriginalSubTotalInclVat.GetHashCode();
                if (this.OriginalSubTotalVat != null)
                    hashCode = hashCode * 59 + this.OriginalSubTotalVat.GetHashCode();
                if (this.OriginalShippingCostsInclVat != null)
                    hashCode = hashCode * 59 + this.OriginalShippingCostsInclVat.GetHashCode();
                if (this.OriginalShippingCostsVat != null)
                    hashCode = hashCode * 59 + this.OriginalShippingCostsVat.GetHashCode();
                if (this.OriginalTotalInclVat != null)
                    hashCode = hashCode * 59 + this.OriginalTotalInclVat.GetHashCode();
                if (this.OriginalTotalVat != null)
                    hashCode = hashCode * 59 + this.OriginalTotalVat.GetHashCode();
                if (this.Lines != null)
                    hashCode = hashCode * 59 + this.Lines.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.CompanyRegistrationNo != null)
                    hashCode = hashCode * 59 + this.CompanyRegistrationNo.GetHashCode();
                if (this.VatNo != null)
                    hashCode = hashCode * 59 + this.VatNo.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.PaymentReferenceNo != null)
                    hashCode = hashCode * 59 + this.PaymentReferenceNo.GetHashCode();
                hashCode = hashCode * 59 + this.ShippingCostsInclVat.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.OrderDate != null)
                    hashCode = hashCode * 59 + this.OrderDate.GetHashCode();
                if (this.ChannelCustomerNo != null)
                    hashCode = hashCode * 59 + this.ChannelCustomerNo.GetHashCode();
                if (this.ExtraData != null)
                    hashCode = hashCode * 59 + this.ExtraData.GetHashCode();
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
            // Phone (string) maxLength
            if (this.Phone != null && this.Phone.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Phone, length must be less than 50.", new[] { "Phone" });
            }

            // Phone (string) minLength
            if (this.Phone != null && this.Phone.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Phone, length must be greater than 0.", new[] { "Phone" });
            }

            // Email (string) maxLength
            if (this.Email != null && this.Email.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be less than 250.", new[] { "Email" });
            }

            // Email (string) minLength
            if (this.Email != null && this.Email.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be greater than 0.", new[] { "Email" });
            }

            // CompanyRegistrationNo (string) maxLength
            if (this.CompanyRegistrationNo != null && this.CompanyRegistrationNo.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompanyRegistrationNo, length must be less than 50.", new[] { "CompanyRegistrationNo" });
            }

            // CompanyRegistrationNo (string) minLength
            if (this.CompanyRegistrationNo != null && this.CompanyRegistrationNo.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompanyRegistrationNo, length must be greater than 0.", new[] { "CompanyRegistrationNo" });
            }

            // VatNo (string) maxLength
            if (this.VatNo != null && this.VatNo.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VatNo, length must be less than 50.", new[] { "VatNo" });
            }

            // VatNo (string) minLength
            if (this.VatNo != null && this.VatNo.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VatNo, length must be greater than 0.", new[] { "VatNo" });
            }

            // PaymentMethod (string) maxLength
            if (this.PaymentMethod != null && this.PaymentMethod.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaymentMethod, length must be less than 50.", new[] { "PaymentMethod" });
            }

            // PaymentMethod (string) minLength
            if (this.PaymentMethod != null && this.PaymentMethod.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaymentMethod, length must be greater than 0.", new[] { "PaymentMethod" });
            }

            // PaymentReferenceNo (string) maxLength
            if (this.PaymentReferenceNo != null && this.PaymentReferenceNo.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaymentReferenceNo, length must be less than 250.", new[] { "PaymentReferenceNo" });
            }

            // PaymentReferenceNo (string) minLength
            if (this.PaymentReferenceNo != null && this.PaymentReferenceNo.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaymentReferenceNo, length must be greater than 0.", new[] { "PaymentReferenceNo" });
            }

            // ShippingCostsInclVat (decimal) minimum
            if (this.ShippingCostsInclVat < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShippingCostsInclVat, must be a value greater than or equal to 0.", new[] { "ShippingCostsInclVat" });
            }

            // CurrencyCode (string) maxLength
            if (this.CurrencyCode != null && this.CurrencyCode.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CurrencyCode, length must be less than 3.", new[] { "CurrencyCode" });
            }

            // ChannelCustomerNo (string) maxLength
            if (this.ChannelCustomerNo != null && this.ChannelCustomerNo.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ChannelCustomerNo, length must be less than 50.", new[] { "ChannelCustomerNo" });
            }

            // ChannelCustomerNo (string) minLength
            if (this.ChannelCustomerNo != null && this.ChannelCustomerNo.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ChannelCustomerNo, length must be greater than 0.", new[] { "ChannelCustomerNo" });
            }

            yield break;
        }
    }
}
