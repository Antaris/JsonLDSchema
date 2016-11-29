// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace JsonLD.Schema
{
    using JsonProperty = Newtonsoft.Json.JsonPropertyAttribute;

    /// <summary>
    /// The act of achieving victory in a competitive activity.
    /// http://schema.org/WinAction
    /// </summary>
    public class WinAction : AchieveAction
    {
        /// <summary>
        /// A sub property of participant. The loser of the action.
        /// </summary>
        [JsonProperty("loser")]
        public Person Loser { get; set; }
    }
}
