// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace JsonLD.Schema
{
    using JsonProperty = Newtonsoft.Json.JsonPropertyAttribute;

    /// <summary>
    /// An agent approves/certifies/likes/supports/sanction an object.
    /// http://schema.org/EndorseAction
    /// </summary>
    public class EndorseAction : AssessAction
    {
        /// <summary>
        /// A sub property of participant. The person/organization being supported.
        /// </summary>
        [JsonProperty("actionOption")]
        public OneOf<Organization, Person> Endorsee{ get; set; }
    }
}
