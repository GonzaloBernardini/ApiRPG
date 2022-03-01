using System.Text.Json.Serialization;

namespace ApiRPG.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {

        Knight,

        Mage,

        Cleric,
    }
}
