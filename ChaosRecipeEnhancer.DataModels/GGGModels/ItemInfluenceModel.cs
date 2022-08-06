﻿using System.Text.Json.Serialization;

namespace ChaosRecipeEnhancer.DataModels.GGGModels
{
    /// <summary>
    /// TODO
    /// </summary>
    /// <seealso cref="https://poe.game.qq.com/developer/docs/reference#type-Item"/>
    public class ItemInfluenceModel
    {
        [JsonPropertyName("shaper")] public bool Shaper { get; set; } = false;

        [JsonPropertyName("elder")] public bool Elder { get; set; } = false;

        [JsonPropertyName("crusader")] public bool Crusader { get; set; } = false;

        [JsonPropertyName("redeemer")] public bool Redeemer { get; set; } = false;

        [JsonPropertyName("hunter")] public bool Hunter { get; set; } = false;

        [JsonPropertyName("warlord")] public bool Warlord { get; set; } = false;
    }
}
