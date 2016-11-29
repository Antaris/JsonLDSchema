// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace JsonLD.Schema
{
    using JsonProperty = Newtonsoft.Json.JsonPropertyAttribute;

    /// <summary>
    /// The act of being defeated in a competitive activity.
    /// http://schema.org/LoseAction
    /// </summary>
    public class LoseAction : AchieveAction
    {
        /// <summary>
        /// A sub property of participant. The winner of the action.
        /// </summary>
        [JsonProperty("winner")]
        public Person Winner { get; set; }
    }
}
