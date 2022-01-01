﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using ChannelEngine.Integration.Dtos.Enums;
using Newtonsoft.Json;

namespace ChannelEngine.Integration.Dtos.Product
{
    /// <summary>
    /// MerchantProductResponse
    /// </summary>
    [DataContract(Name = "MerchantProductResponse")]
    public partial class MerchantProductResponse : IEquatable<MerchantProductResponse>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets VatRateType
        /// </summary>
        [DataMember(Name = "VatRateType", EmitDefaultValue = false)]
        public VatRateType? VatRateType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantProductResponse" /> class.
        /// </summary>
        /// <param name="isActive">Is the product active for the Merchant?..</param>
        /// <param name="merchantProductNo">A unique identifier of the product. (sku)..</param>
        /// <param name="extraData">extraData.</param>
        /// <param name="name">The name of the product..</param>
        /// <param name="description">A description of the product. Can contain these HTML tags:  div, span, pre, p, br, hr, hgroup, h1, h2, h3, h4, h5, h6, ul, ol, li, dl, dt, dd, strong, em, b, i, u, img, a, abbr, address, blockquote, area, audio, video, caption, table, tbody, td, tfoot, th, thead, tr..</param>
        /// <param name="brand">The brand of the product..</param>
        /// <param name="size">Optional. The size of the product (variant). E.g. fashion size (S-XL, 46-56, etc), width of the watch, etc...</param>
        /// <param name="color">Optional. The color of the product (variant)..</param>
        /// <param name="ean">The EAN of GTIN of the product..</param>
        /// <param name="manufacturerProductNumber">The unique product reference used by the manufacturer/vendor of the product..</param>
        /// <param name="stock">The number of items in stock..</param>
        /// <param name="price">Price, including VAT..</param>
        /// <param name="mSRP">Manufacturer&#39;s suggested retail price..</param>
        /// <param name="purchasePrice">Optional. The purchase price of the product. Useful for repricing..</param>
        /// <param name="vatRateType">vatRateType.</param>
        /// <param name="shippingCost">Shipping cost of the product..</param>
        /// <param name="shippingTime">A textual representation of the shippingtime.  For example, in Dutch: &#39;Op werkdagen voor 22:00 uur besteld, morgen in huis&#39;..</param>
        /// <param name="url">A URL pointing to the merchant&#39;s webpage  which displays this product..</param>
        /// <param name="imageUrl">A URL at which an image of this product  can be found..</param>
        /// <param name="extraImageUrl1">Url to an additional image of product (1)..</param>
        /// <param name="extraImageUrl2">Url to an additional image of product (2)..</param>
        /// <param name="extraImageUrl3">Url to an additional image of product (3)..</param>
        /// <param name="extraImageUrl4">Url to an additional image of product (4)..</param>
        /// <param name="extraImageUrl5">Url to an additional image of product (5)..</param>
        /// <param name="extraImageUrl6">Url to an additional image of product (6)..</param>
        /// <param name="extraImageUrl7">Url to an additional image of product (7)..</param>
        /// <param name="extraImageUrl8">Url to an additional image of product (8)..</param>
        /// <param name="extraImageUrl9">Url to an additional image of product (9)..</param>
        /// <param name="categoryTrail">The category to which this product belongs.  Please supply this field in the following format:  &#39;maincategory &gt; category &gt; subcategory&#39;  For example:  &#39;vehicles &gt; bikes &gt; mountainbike&#39;..</param>
        public MerchantProductResponse(bool isActive = default(bool), string merchantProductNo = default(string), List<MerchantProductExtraDataItemResponse> extraData = default(List<MerchantProductExtraDataItemResponse>), string name = default(string), string description = default(string), string brand = default(string), string size = default(string), string color = default(string), string ean = default(string), string manufacturerProductNumber = default(string), int stock = default(int), decimal price = default(decimal), decimal? mSRP = default(decimal?), decimal? purchasePrice = default(decimal?), VatRateType? vatRateType = default(VatRateType?), decimal? shippingCost = default(decimal?), string shippingTime = default(string), string url = default(string), string imageUrl = default(string), string extraImageUrl1 = default(string), string extraImageUrl2 = default(string), string extraImageUrl3 = default(string), string extraImageUrl4 = default(string), string extraImageUrl5 = default(string), string extraImageUrl6 = default(string), string extraImageUrl7 = default(string), string extraImageUrl8 = default(string), string extraImageUrl9 = default(string), string categoryTrail = default(string))
        {
            this.IsActive = isActive;
            this.MerchantProductNo = merchantProductNo;
            this.ExtraData = extraData;
            this.Name = name;
            this.Description = description;
            this.Brand = brand;
            this.Size = size;
            this.Color = color;
            this.Ean = ean;
            this.ManufacturerProductNumber = manufacturerProductNumber;
            this.Stock = stock;
            this.Price = price;
            this.MSRP = mSRP;
            this.PurchasePrice = purchasePrice;
            this.VatRateType = vatRateType;
            this.ShippingCost = shippingCost;
            this.ShippingTime = shippingTime;
            this.Url = url;
            this.ImageUrl = imageUrl;
            this.ExtraImageUrl1 = extraImageUrl1;
            this.ExtraImageUrl2 = extraImageUrl2;
            this.ExtraImageUrl3 = extraImageUrl3;
            this.ExtraImageUrl4 = extraImageUrl4;
            this.ExtraImageUrl5 = extraImageUrl5;
            this.ExtraImageUrl6 = extraImageUrl6;
            this.ExtraImageUrl7 = extraImageUrl7;
            this.ExtraImageUrl8 = extraImageUrl8;
            this.ExtraImageUrl9 = extraImageUrl9;
            this.CategoryTrail = categoryTrail;
        }

        /// <summary>
        /// Is the product active for the Merchant?.
        /// </summary>
        /// <value>Is the product active for the Merchant?.</value>
        [DataMember(Name = "IsActive", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// A unique identifier of the product. (sku).
        /// </summary>
        /// <value>A unique identifier of the product. (sku).</value>
        [DataMember(Name = "MerchantProductNo", EmitDefaultValue = true)]
        public string MerchantProductNo { get; set; }

        /// <summary>
        /// Gets or Sets ExtraData
        /// </summary>
        [DataMember(Name = "ExtraData", EmitDefaultValue = true)]
        public List<MerchantProductExtraDataItemResponse> ExtraData { get; set; }

        /// <summary>
        /// The name of the product.
        /// </summary>
        /// <value>The name of the product.</value>
        [DataMember(Name = "Name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// A description of the product. Can contain these HTML tags:  div, span, pre, p, br, hr, hgroup, h1, h2, h3, h4, h5, h6, ul, ol, li, dl, dt, dd, strong, em, b, i, u, img, a, abbr, address, blockquote, area, audio, video, caption, table, tbody, td, tfoot, th, thead, tr.
        /// </summary>
        /// <value>A description of the product. Can contain these HTML tags:  div, span, pre, p, br, hr, hgroup, h1, h2, h3, h4, h5, h6, ul, ol, li, dl, dt, dd, strong, em, b, i, u, img, a, abbr, address, blockquote, area, audio, video, caption, table, tbody, td, tfoot, th, thead, tr.</value>
        [DataMember(Name = "Description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The brand of the product.
        /// </summary>
        /// <value>The brand of the product.</value>
        [DataMember(Name = "Brand", EmitDefaultValue = true)]
        public string Brand { get; set; }

        /// <summary>
        /// Optional. The size of the product (variant). E.g. fashion size (S-XL, 46-56, etc), width of the watch, etc..
        /// </summary>
        /// <value>Optional. The size of the product (variant). E.g. fashion size (S-XL, 46-56, etc), width of the watch, etc..</value>
        [DataMember(Name = "Size", EmitDefaultValue = true)]
        public string Size { get; set; }

        /// <summary>
        /// Optional. The color of the product (variant).
        /// </summary>
        /// <value>Optional. The color of the product (variant).</value>
        [DataMember(Name = "Color", EmitDefaultValue = true)]
        public string Color { get; set; }

        /// <summary>
        /// The EAN of GTIN of the product.
        /// </summary>
        /// <value>The EAN of GTIN of the product.</value>
        [DataMember(Name = "Ean", EmitDefaultValue = true)]
        public string Ean { get; set; }

        /// <summary>
        /// The unique product reference used by the manufacturer/vendor of the product.
        /// </summary>
        /// <value>The unique product reference used by the manufacturer/vendor of the product.</value>
        [DataMember(Name = "ManufacturerProductNumber", EmitDefaultValue = true)]
        public string ManufacturerProductNumber { get; set; }

        /// <summary>
        /// The number of items in stock.
        /// </summary>
        /// <value>The number of items in stock.</value>
        [DataMember(Name = "Stock", EmitDefaultValue = false)]
        public int Stock { get; set; }

        /// <summary>
        /// Price, including VAT.
        /// </summary>
        /// <value>Price, including VAT.</value>
        [DataMember(Name = "Price", EmitDefaultValue = false)]
        public decimal Price { get; set; }

        /// <summary>
        /// Manufacturer&#39;s suggested retail price.
        /// </summary>
        /// <value>Manufacturer&#39;s suggested retail price.</value>
        [DataMember(Name = "MSRP", EmitDefaultValue = true)]
        public decimal? MSRP { get; set; }

        /// <summary>
        /// Optional. The purchase price of the product. Useful for repricing.
        /// </summary>
        /// <value>Optional. The purchase price of the product. Useful for repricing.</value>
        [DataMember(Name = "PurchasePrice", EmitDefaultValue = true)]
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Shipping cost of the product.
        /// </summary>
        /// <value>Shipping cost of the product.</value>
        [DataMember(Name = "ShippingCost", EmitDefaultValue = true)]
        public decimal? ShippingCost { get; set; }

        /// <summary>
        /// A textual representation of the shippingtime.  For example, in Dutch: &#39;Op werkdagen voor 22:00 uur besteld, morgen in huis&#39;.
        /// </summary>
        /// <value>A textual representation of the shippingtime.  For example, in Dutch: &#39;Op werkdagen voor 22:00 uur besteld, morgen in huis&#39;.</value>
        [DataMember(Name = "ShippingTime", EmitDefaultValue = true)]
        public string ShippingTime { get; set; }

        /// <summary>
        /// A URL pointing to the merchant&#39;s webpage  which displays this product.
        /// </summary>
        /// <value>A URL pointing to the merchant&#39;s webpage  which displays this product.</value>
        [DataMember(Name = "Url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// A URL at which an image of this product  can be found.
        /// </summary>
        /// <value>A URL at which an image of this product  can be found.</value>
        [DataMember(Name = "ImageUrl", EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Url to an additional image of product (1).
        /// </summary>
        /// <value>Url to an additional image of product (1).</value>
        [DataMember(Name = "ExtraImageUrl1", EmitDefaultValue = true)]
        public string ExtraImageUrl1 { get; set; }

        /// <summary>
        /// Url to an additional image of product (2).
        /// </summary>
        /// <value>Url to an additional image of product (2).</value>
        [DataMember(Name = "ExtraImageUrl2", EmitDefaultValue = true)]
        public string ExtraImageUrl2 { get; set; }

        /// <summary>
        /// Url to an additional image of product (3).
        /// </summary>
        /// <value>Url to an additional image of product (3).</value>
        [DataMember(Name = "ExtraImageUrl3", EmitDefaultValue = true)]
        public string ExtraImageUrl3 { get; set; }

        /// <summary>
        /// Url to an additional image of product (4).
        /// </summary>
        /// <value>Url to an additional image of product (4).</value>
        [DataMember(Name = "ExtraImageUrl4", EmitDefaultValue = true)]
        public string ExtraImageUrl4 { get; set; }

        /// <summary>
        /// Url to an additional image of product (5).
        /// </summary>
        /// <value>Url to an additional image of product (5).</value>
        [DataMember(Name = "ExtraImageUrl5", EmitDefaultValue = true)]
        public string ExtraImageUrl5 { get; set; }

        /// <summary>
        /// Url to an additional image of product (6).
        /// </summary>
        /// <value>Url to an additional image of product (6).</value>
        [DataMember(Name = "ExtraImageUrl6", EmitDefaultValue = true)]
        public string ExtraImageUrl6 { get; set; }

        /// <summary>
        /// Url to an additional image of product (7).
        /// </summary>
        /// <value>Url to an additional image of product (7).</value>
        [DataMember(Name = "ExtraImageUrl7", EmitDefaultValue = true)]
        public string ExtraImageUrl7 { get; set; }

        /// <summary>
        /// Url to an additional image of product (8).
        /// </summary>
        /// <value>Url to an additional image of product (8).</value>
        [DataMember(Name = "ExtraImageUrl8", EmitDefaultValue = true)]
        public string ExtraImageUrl8 { get; set; }

        /// <summary>
        /// Url to an additional image of product (9).
        /// </summary>
        /// <value>Url to an additional image of product (9).</value>
        [DataMember(Name = "ExtraImageUrl9", EmitDefaultValue = true)]
        public string ExtraImageUrl9 { get; set; }

        /// <summary>
        /// The category to which this product belongs.  Please supply this field in the following format:  &#39;maincategory &gt; category &gt; subcategory&#39;  For example:  &#39;vehicles &gt; bikes &gt; mountainbike&#39;.
        /// </summary>
        /// <value>The category to which this product belongs.  Please supply this field in the following format:  &#39;maincategory &gt; category &gt; subcategory&#39;  For example:  &#39;vehicles &gt; bikes &gt; mountainbike&#39;.</value>
        [DataMember(Name = "CategoryTrail", EmitDefaultValue = true)]
        public string CategoryTrail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantProductResponse {\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  MerchantProductNo: ").Append(MerchantProductNo).Append("\n");
            sb.Append("  ExtraData: ").Append(ExtraData).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Ean: ").Append(Ean).Append("\n");
            sb.Append("  ManufacturerProductNumber: ").Append(ManufacturerProductNumber).Append("\n");
            sb.Append("  Stock: ").Append(Stock).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  MSRP: ").Append(MSRP).Append("\n");
            sb.Append("  PurchasePrice: ").Append(PurchasePrice).Append("\n");
            sb.Append("  VatRateType: ").Append(VatRateType).Append("\n");
            sb.Append("  ShippingCost: ").Append(ShippingCost).Append("\n");
            sb.Append("  ShippingTime: ").Append(ShippingTime).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  ExtraImageUrl1: ").Append(ExtraImageUrl1).Append("\n");
            sb.Append("  ExtraImageUrl2: ").Append(ExtraImageUrl2).Append("\n");
            sb.Append("  ExtraImageUrl3: ").Append(ExtraImageUrl3).Append("\n");
            sb.Append("  ExtraImageUrl4: ").Append(ExtraImageUrl4).Append("\n");
            sb.Append("  ExtraImageUrl5: ").Append(ExtraImageUrl5).Append("\n");
            sb.Append("  ExtraImageUrl6: ").Append(ExtraImageUrl6).Append("\n");
            sb.Append("  ExtraImageUrl7: ").Append(ExtraImageUrl7).Append("\n");
            sb.Append("  ExtraImageUrl8: ").Append(ExtraImageUrl8).Append("\n");
            sb.Append("  ExtraImageUrl9: ").Append(ExtraImageUrl9).Append("\n");
            sb.Append("  CategoryTrail: ").Append(CategoryTrail).Append("\n");
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
            return this.Equals(input as MerchantProductResponse);
        }

        /// <summary>
        /// Returns true if MerchantProductResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantProductResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantProductResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) &&
                (
                    this.MerchantProductNo == input.MerchantProductNo ||
                    (this.MerchantProductNo != null &&
                    this.MerchantProductNo.Equals(input.MerchantProductNo))
                ) &&
                (
                    this.ExtraData == input.ExtraData ||
                    this.ExtraData != null &&
                    input.ExtraData != null &&
                    this.ExtraData.SequenceEqual(input.ExtraData)
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) &&
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) &&
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) &&
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) &&
                (
                    this.Ean == input.Ean ||
                    (this.Ean != null &&
                    this.Ean.Equals(input.Ean))
                ) &&
                (
                    this.ManufacturerProductNumber == input.ManufacturerProductNumber ||
                    (this.ManufacturerProductNumber != null &&
                    this.ManufacturerProductNumber.Equals(input.ManufacturerProductNumber))
                ) &&
                (
                    this.Stock == input.Stock ||
                    this.Stock.Equals(input.Stock)
                ) &&
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) &&
                (
                    this.MSRP == input.MSRP ||
                    (this.MSRP != null &&
                    this.MSRP.Equals(input.MSRP))
                ) &&
                (
                    this.PurchasePrice == input.PurchasePrice ||
                    (this.PurchasePrice != null &&
                    this.PurchasePrice.Equals(input.PurchasePrice))
                ) &&
                (
                    this.VatRateType == input.VatRateType ||
                    this.VatRateType.Equals(input.VatRateType)
                ) &&
                (
                    this.ShippingCost == input.ShippingCost ||
                    (this.ShippingCost != null &&
                    this.ShippingCost.Equals(input.ShippingCost))
                ) &&
                (
                    this.ShippingTime == input.ShippingTime ||
                    (this.ShippingTime != null &&
                    this.ShippingTime.Equals(input.ShippingTime))
                ) &&
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) &&
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) &&
                (
                    this.ExtraImageUrl1 == input.ExtraImageUrl1 ||
                    (this.ExtraImageUrl1 != null &&
                    this.ExtraImageUrl1.Equals(input.ExtraImageUrl1))
                ) &&
                (
                    this.ExtraImageUrl2 == input.ExtraImageUrl2 ||
                    (this.ExtraImageUrl2 != null &&
                    this.ExtraImageUrl2.Equals(input.ExtraImageUrl2))
                ) &&
                (
                    this.ExtraImageUrl3 == input.ExtraImageUrl3 ||
                    (this.ExtraImageUrl3 != null &&
                    this.ExtraImageUrl3.Equals(input.ExtraImageUrl3))
                ) &&
                (
                    this.ExtraImageUrl4 == input.ExtraImageUrl4 ||
                    (this.ExtraImageUrl4 != null &&
                    this.ExtraImageUrl4.Equals(input.ExtraImageUrl4))
                ) &&
                (
                    this.ExtraImageUrl5 == input.ExtraImageUrl5 ||
                    (this.ExtraImageUrl5 != null &&
                    this.ExtraImageUrl5.Equals(input.ExtraImageUrl5))
                ) &&
                (
                    this.ExtraImageUrl6 == input.ExtraImageUrl6 ||
                    (this.ExtraImageUrl6 != null &&
                    this.ExtraImageUrl6.Equals(input.ExtraImageUrl6))
                ) &&
                (
                    this.ExtraImageUrl7 == input.ExtraImageUrl7 ||
                    (this.ExtraImageUrl7 != null &&
                    this.ExtraImageUrl7.Equals(input.ExtraImageUrl7))
                ) &&
                (
                    this.ExtraImageUrl8 == input.ExtraImageUrl8 ||
                    (this.ExtraImageUrl8 != null &&
                    this.ExtraImageUrl8.Equals(input.ExtraImageUrl8))
                ) &&
                (
                    this.ExtraImageUrl9 == input.ExtraImageUrl9 ||
                    (this.ExtraImageUrl9 != null &&
                    this.ExtraImageUrl9.Equals(input.ExtraImageUrl9))
                ) &&
                (
                    this.CategoryTrail == input.CategoryTrail ||
                    (this.CategoryTrail != null &&
                    this.CategoryTrail.Equals(input.CategoryTrail))
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
                hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.MerchantProductNo != null)
                    hashCode = hashCode * 59 + this.MerchantProductNo.GetHashCode();
                if (this.ExtraData != null)
                    hashCode = hashCode * 59 + this.ExtraData.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Brand != null)
                    hashCode = hashCode * 59 + this.Brand.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.Ean != null)
                    hashCode = hashCode * 59 + this.Ean.GetHashCode();
                if (this.ManufacturerProductNumber != null)
                    hashCode = hashCode * 59 + this.ManufacturerProductNumber.GetHashCode();
                hashCode = hashCode * 59 + this.Stock.GetHashCode();
                hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.MSRP != null)
                    hashCode = hashCode * 59 + this.MSRP.GetHashCode();
                if (this.PurchasePrice != null)
                    hashCode = hashCode * 59 + this.PurchasePrice.GetHashCode();
                hashCode = hashCode * 59 + this.VatRateType.GetHashCode();
                if (this.ShippingCost != null)
                    hashCode = hashCode * 59 + this.ShippingCost.GetHashCode();
                if (this.ShippingTime != null)
                    hashCode = hashCode * 59 + this.ShippingTime.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.ExtraImageUrl1 != null)
                    hashCode = hashCode * 59 + this.ExtraImageUrl1.GetHashCode();
                if (this.ExtraImageUrl2 != null)
                    hashCode = hashCode * 59 + this.ExtraImageUrl2.GetHashCode();
                if (this.ExtraImageUrl3 != null)
                    hashCode = hashCode * 59 + this.ExtraImageUrl3.GetHashCode();
                if (this.ExtraImageUrl4 != null)
                    hashCode = hashCode * 59 + this.ExtraImageUrl4.GetHashCode();
                if (this.ExtraImageUrl5 != null)
                    hashCode = hashCode * 59 + this.ExtraImageUrl5.GetHashCode();
                if (this.ExtraImageUrl6 != null)
                    hashCode = hashCode * 59 + this.ExtraImageUrl6.GetHashCode();
                if (this.ExtraImageUrl7 != null)
                    hashCode = hashCode * 59 + this.ExtraImageUrl7.GetHashCode();
                if (this.ExtraImageUrl8 != null)
                    hashCode = hashCode * 59 + this.ExtraImageUrl8.GetHashCode();
                if (this.ExtraImageUrl9 != null)
                    hashCode = hashCode * 59 + this.ExtraImageUrl9.GetHashCode();
                if (this.CategoryTrail != null)
                    hashCode = hashCode * 59 + this.CategoryTrail.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 256.", new[] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 0.", new[] { "Name" });
            }

            // Brand (string) maxLength
            if (this.Brand != null && this.Brand.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Brand, length must be less than 256.", new[] { "Brand" });
            }

            // Brand (string) minLength
            if (this.Brand != null && this.Brand.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Brand, length must be greater than 0.", new[] { "Brand" });
            }

            // Size (string) maxLength
            if (this.Size != null && this.Size.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Size, length must be less than 64.", new[] { "Size" });
            }

            // Size (string) minLength
            if (this.Size != null && this.Size.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Size, length must be greater than 0.", new[] { "Size" });
            }

            // Color (string) maxLength
            if (this.Color != null && this.Color.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Color, length must be less than 64.", new[] { "Color" });
            }

            // Color (string) minLength
            if (this.Color != null && this.Color.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Color, length must be greater than 0.", new[] { "Color" });
            }

            // Ean (string) maxLength
            if (this.Ean != null && this.Ean.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Ean, length must be less than 64.", new[] { "Ean" });
            }

            // Ean (string) minLength
            if (this.Ean != null && this.Ean.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Ean, length must be greater than 0.", new[] { "Ean" });
            }

            // ManufacturerProductNumber (string) maxLength
            if (this.ManufacturerProductNumber != null && this.ManufacturerProductNumber.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ManufacturerProductNumber, length must be less than 64.", new[] { "ManufacturerProductNumber" });
            }

            // ManufacturerProductNumber (string) minLength
            if (this.ManufacturerProductNumber != null && this.ManufacturerProductNumber.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ManufacturerProductNumber, length must be greater than 0.", new[] { "ManufacturerProductNumber" });
            }

            // Stock (int) minimum
            if (this.Stock < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Stock, must be a value greater than or equal to 0.", new[] { "Stock" });
            }

            // Price (decimal) minimum
            if (this.Price < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Price, must be a value greater than or equal to 0.", new[] { "Price" });
            }

            // ShippingTime (string) maxLength
            if (this.ShippingTime != null && this.ShippingTime.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShippingTime, length must be less than 128.", new[] { "ShippingTime" });
            }

            // ShippingTime (string) minLength
            if (this.ShippingTime != null && this.ShippingTime.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShippingTime, length must be greater than 0.", new[] { "ShippingTime" });
            }

            // Url (string) maxLength
            if (this.Url != null && this.Url.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, length must be less than 512.", new[] { "Url" });
            }

            // Url (string) minLength
            if (this.Url != null && this.Url.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, length must be greater than 0.", new[] { "Url" });
            }

            // ImageUrl (string) maxLength
            if (this.ImageUrl != null && this.ImageUrl.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImageUrl, length must be less than 512.", new[] { "ImageUrl" });
            }

            // ImageUrl (string) minLength
            if (this.ImageUrl != null && this.ImageUrl.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImageUrl, length must be greater than 0.", new[] { "ImageUrl" });
            }

            // ExtraImageUrl1 (string) maxLength
            if (this.ExtraImageUrl1 != null && this.ExtraImageUrl1.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExtraImageUrl1, length must be less than 512.", new[] { "ExtraImageUrl1" });
            }

            // ExtraImageUrl1 (string) minLength
            if (this.ExtraImageUrl1 != null && this.ExtraImageUrl1.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExtraImageUrl1, length must be greater than 0.", new[] { "ExtraImageUrl1" });
            }

            // ExtraImageUrl2 (string) maxLength
            if (this.ExtraImageUrl2 != null && this.ExtraImageUrl2.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExtraImageUrl2, length must be less than 512.", new[] { "ExtraImageUrl2" });
            }

            // ExtraImageUrl2 (string) minLength
            if (this.ExtraImageUrl2 != null && this.ExtraImageUrl2.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExtraImageUrl2, length must be greater than 0.", new[] { "ExtraImageUrl2" });
            }

            // ExtraImageUrl3 (string) maxLength
            if (this.ExtraImageUrl3 != null && this.ExtraImageUrl3.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExtraImageUrl3, length must be less than 512.", new[] { "ExtraImageUrl3" });
            }

            // ExtraImageUrl3 (string) minLength
            if (this.ExtraImageUrl3 != null && this.ExtraImageUrl3.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExtraImageUrl3, length must be greater than 0.", new[] { "ExtraImageUrl3" });
            }

            // ExtraImageUrl4 (string) maxLength
            if (this.ExtraImageUrl4 != null && this.ExtraImageUrl4.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExtraImageUrl4, length must be less than 512.", new[] { "ExtraImageUrl4" });
            }

            // ExtraImageUrl4 (string) minLength
            if (this.ExtraImageUrl4 != null && this.ExtraImageUrl4.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExtraImageUrl4, length must be greater than 0.", new[] { "ExtraImageUrl4" });
            }

            // ExtraImageUrl5 (string) maxLength
            if (this.ExtraImageUrl5 != null && this.ExtraImageUrl5.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExtraImageUrl5, length must be less than 512.", new[] { "ExtraImageUrl5" });
            }

            // ExtraImageUrl5 (string) minLength
            if (this.ExtraImageUrl5 != null && this.ExtraImageUrl5.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExtraImageUrl5, length must be greater than 0.", new[] { "ExtraImageUrl5" });
            }

            // ExtraImageUrl6 (string) maxLength
            if (this.ExtraImageUrl6 != null && this.ExtraImageUrl6.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExtraImageUrl6, length must be less than 512.", new[] { "ExtraImageUrl6" });
            }

            // ExtraImageUrl6 (string) minLength
            if (this.ExtraImageUrl6 != null && this.ExtraImageUrl6.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExtraImageUrl6, length must be greater than 0.", new[] { "ExtraImageUrl6" });
            }

            // ExtraImageUrl7 (string) maxLength
            if (this.ExtraImageUrl7 != null && this.ExtraImageUrl7.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExtraImageUrl7, length must be less than 512.", new[] { "ExtraImageUrl7" });
            }

            // ExtraImageUrl7 (string) minLength
            if (this.ExtraImageUrl7 != null && this.ExtraImageUrl7.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExtraImageUrl7, length must be greater than 0.", new[] { "ExtraImageUrl7" });
            }

            // ExtraImageUrl8 (string) maxLength
            if (this.ExtraImageUrl8 != null && this.ExtraImageUrl8.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExtraImageUrl8, length must be less than 512.", new[] { "ExtraImageUrl8" });
            }

            // ExtraImageUrl8 (string) minLength
            if (this.ExtraImageUrl8 != null && this.ExtraImageUrl8.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExtraImageUrl8, length must be greater than 0.", new[] { "ExtraImageUrl8" });
            }

            // ExtraImageUrl9 (string) maxLength
            if (this.ExtraImageUrl9 != null && this.ExtraImageUrl9.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExtraImageUrl9, length must be less than 512.", new[] { "ExtraImageUrl9" });
            }

            // ExtraImageUrl9 (string) minLength
            if (this.ExtraImageUrl9 != null && this.ExtraImageUrl9.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExtraImageUrl9, length must be greater than 0.", new[] { "ExtraImageUrl9" });
            }

            yield break;
        }
    }
}
