using System.Text.Json.Serialization;

namespace dotnetcore.Models
{
  [JsonConverter(typeof(JsonStringEnumConverter))]
  public enum RpgClass
  {
    Knight,
    Mage,
    Cleric
  }
}