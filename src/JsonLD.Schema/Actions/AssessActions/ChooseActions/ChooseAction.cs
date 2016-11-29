// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace JsonLD.Schema
{
    using JsonProperty = Newtonsoft.Json.JsonPropertyAttribute;

    /// <summary>
    /// The act of expressing a preference from a set of options or a large or unbounded 
    /// set of choices/options.
    /// http://schema.org/ChooseAction
    /// </summary>
    public class ChooseAction : AssessAction
    {
        /// <summary>
        /// A sub property of object. The options subject to this action.
        /// </summary>
        [JsonProperty("actionOption")]
        public OneOf<string, Thing> ActionOption { get; set; }
    }
}
