﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using ChannelEngine.Integration.Dtos.Enums;

namespace ChannelEngine.Integration.Dtos.Product
{
    /// <summary>
    /// MerchantProductExtraDataItemRequest
    /// </summary>
    [DataContract(Name = "MerchantProductExtraDataItemRequest")]
    public partial class MerchantProductExtraDataItemRequest : IEquatable<MerchantProductExtraDataItemRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "Type", EmitDefaultValue = false)]
        public ExtraDataType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantProductExtraDataItemRequest" /> class.
        /// </summary>
        /// <param name="key">Name of the extra data field..</param>
        /// <param name="value">Value of the extra data field..</param>
        /// <param name="type">type.</param>
        /// <param name="isPublic">Add this field to the export of the product feed to the channel..</param>
        public MerchantProductExtraDataItemRequest(string key = default(string), string value = default(string), ExtraDataType? type = default(ExtraDataType?), bool isPublic = default(bool))
        {
            this.Key = key;
            this.Value = value;
            this.Type = type;
            this.IsPublic = isPublic;
        }

        /// <summary>
        /// Name of the extra data field.
        /// </summary>
        /// <value>Name of the extra data field.</value>
        [DataMember(Name = "Key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Value of the extra data field.
        /// </summary>
        /// <value>Value of the extra data field.</value>
        [DataMember(Name = "Value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Add this field to the export of the product feed to the channel.
        /// </summary>
        /// <value>Add this field to the export of the product feed to the channel.</value>
        [DataMember(Name = "IsPublic", EmitDefaultValue = true)]
        public bool IsPublic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantProductExtraDataItemRequest {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
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
            return this.Equals(input as MerchantProductExtraDataItemRequest);
        }

        /// <summary>
        /// Returns true if MerchantProductExtraDataItemRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantProductExtraDataItemRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantProductExtraDataItemRequest input)
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
                ) &&
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) &&
                (
                    this.IsPublic == input.IsPublic ||
                    this.IsPublic.Equals(input.IsPublic)
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.IsPublic.GetHashCode();
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
            // Key (string) maxLength
            if (this.Key != null && this.Key.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Key, length must be less than 100.", new[] { "Key" });
            }

            // Key (string) minLength
            if (this.Key != null && this.Key.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Key, length must be greater than 0.", new[] { "Key" });
            }

            // Value (string) maxLength
            if (this.Value != null && this.Value.Length > -1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, length must be less than -1.", new[] { "Value" });
            }

            yield break;
        }
    }
}
