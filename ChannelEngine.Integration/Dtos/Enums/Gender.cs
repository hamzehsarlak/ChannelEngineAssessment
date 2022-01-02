using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ChannelEngine.Integration.Dtos.Enums
{
    /// <summary>
    /// Defines Gender
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum Gender
    {
        /// <summary>
        /// Enum MALE for value: MALE
        /// </summary>
        [EnumMember(Value = "MALE")]
        MALE = 1,

        /// <summary>
        /// Enum FEMALE for value: FEMALE
        /// </summary>
        [EnumMember(Value = "FEMALE")]
        FEMALE = 2,

        /// <summary>
        /// Enum NOTAPPLICABLE for value: NOT_APPLICABLE
        /// </summary>
        [EnumMember(Value = "NOT_APPLICABLE")]
        NOT_APPLICABLE = 3

    }
}
