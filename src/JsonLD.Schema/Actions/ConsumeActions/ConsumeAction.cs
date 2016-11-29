// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace JsonLD.Schema
{
    using JsonProperty = Newtonsoft.Json.JsonPropertyAttribute;

    /// <summary>
    /// The act of ingesting information/resources/food.
    /// http://schema.org/ConsumeAction
    /// </summary>
    public class ConsumeAction : Action
    {
        /// <summary>
        /// An Offer which must be accepted before the user can perform the Action. For example, the 
        /// user may need to buy a movie before being able to watch it.
        /// </summary>
        [JsonProperty("expectsAcceptanceOf")]
        public Offer ExpectsAcceptanceOf { get; set; }
    }
}
