using System.Text.Json.Serialization;

namespace ChaosRecipeEnhancer.DataModels.GGGModels
{
    /// <summary>
    /// TODO
    /// </summary>
    /// <seealso cref="https://poe.game.qq.com/developer/docs/reference#type-ItemProperty"/>
    public class ItemPropertyModel
    {
        [JsonPropertyName("name")] public string Name { get; set; }

        [JsonPropertyName("displayMode")] public int DisplayMode { get; set; }

        [JsonPropertyName("type")] public int Type { get; set; }
    }
}
