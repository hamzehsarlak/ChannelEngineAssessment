using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ChannelEngine.Integration.Dtos.Enums
{
    /// <summary>
    /// Defines OrderSupport
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum OrderSupport
    {
        /// <summary>
        /// Enum NONE for value: NONE
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE = 1,

        /// <summary>
        /// Enum ORDERS for value: ORDERS
        /// </summary>
        [EnumMember(Value = "ORDERS")]
        ORDERS = 2,

        /// <summary>
        /// Enum SPLITORDERS for value: SPLIT_ORDERS
        /// </summary>
        [EnumMember(Value = "SPLIT_ORDERS")]
        SPLIT_ORDERS = 3,

        /// <summary>
        /// Enum SPLITORDERLINES for value: SPLIT_ORDER_LINES
        /// </summary>
        [EnumMember(Value = "SPLIT_ORDER_LINES")]
        SPLIT_ORDER_LINES = 4

    }
}
