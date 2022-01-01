﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace ChannelEngine.Integration.Dtos.Order
{
    /// <summary>
    /// MerchantOrderLineExtraDataResponse
    /// </summary>
    [DataContract(Name = "MerchantOrderLineExtraDataResponse")]
    public partial class MerchantOrderLineExtraDataResponse : IEquatable<MerchantOrderLineExtraDataResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantOrderLineExtraDataResponse" /> class.
        /// </summary>
        /// <param name="key">key.</param>
        /// <param name="value">value.</param>
        public MerchantOrderLineExtraDataResponse(string key = default(string), string value = default(string))
        {
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "Key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "Value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantOrderLineExtraDataResponse {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as MerchantOrderLineExtraDataResponse);
        }

        /// <summary>
        /// Returns true if MerchantOrderLineExtraDataResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantOrderLineExtraDataResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantOrderLineExtraDataResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) &&
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
            yield break;
        }
    }
}