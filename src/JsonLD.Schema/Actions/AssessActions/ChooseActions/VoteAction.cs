// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace JsonLD.Schema
{
    using JsonProperty = Newtonsoft.Json.JsonPropertyAttribute;

    /// <summary>
    /// The act of expressing a preference from a fixed/finite/structured set of
    /// choices/options.
    /// http://schema.org/VoteAction
    /// </summary>
    public class VoteAction : ChooseAction
    {
        /// <summary>
        /// A sub property of object. The candidate subject of this action.
        /// </summary>
        [JsonProperty("candidate")]
        public Person Candidate { get; set; }
    }
}
