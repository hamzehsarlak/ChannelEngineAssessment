using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ChannelEngine.Integration.Dtos.Enums
{
    /// <summary>
    /// Defines VatRateType
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum VatRateType
    {
        /// <summary>
        /// Enum STANDARD for value: STANDARD
        /// </summary>
        [EnumMember(Value = "STANDARD")]
        STANDARD = 1,

        /// <summary>
        /// Enum REDUCED for value: REDUCED
        /// </summary>
        [EnumMember(Value = "REDUCED")]
        REDUCED = 2,

        /// <summary>
        /// Enum SUPERREDUCED for value: SUPER_REDUCED
        /// </summary>
        [EnumMember(Value = "SUPER_REDUCED")]
        SUPER_REDUCED = 3,

        /// <summary>
        /// Enum EXEMPT for value: EXEMPT
        /// </summary>
        [EnumMember(Value = "EXEMPT")]
        EXEMPT = 4

    }
}
