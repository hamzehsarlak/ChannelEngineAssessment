using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ChannelEngine.Integration.Dtos.Enums
{
    /// <summary>
    /// Defines ExtraDataType
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum ExtraDataType
    {
        /// <summary>
        /// Enum TEXT for value: TEXT
        /// </summary>
        [EnumMember(Value = "TEXT")]
        TEXT = 1,

        /// <summary>
        /// Enum NUMBER for value: NUMBER
        /// </summary>
        [EnumMember(Value = "NUMBER")]
        NUMBER = 2,

        /// <summary>
        /// Enum URL for value: URL
        /// </summary>
        [EnumMember(Value = "URL")]
        URL = 3,

        /// <summary>
        /// Enum IMAGEURL for value: IMAGEURL
        /// </summary>
        [EnumMember(Value = "IMAGEURL")]
        IMAGEURL = 4

    }
}
