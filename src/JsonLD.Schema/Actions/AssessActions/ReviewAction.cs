// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace JsonLD.Schema
{
    using JsonProperty = Newtonsoft.Json.JsonPropertyAttribute;

    /// <summary>
    /// The act of producing a balanced opinion about the object for an audience. An agent 
    /// reviews an object with participants resulting in a review.
    /// http://schema.org/ReviewAction
    /// </summary>
    public class ReviewAction : AssessAction
    {
        /// <summary>
        /// A sub property of result. The review that resulted in the performing of the 
        /// action.
        /// </summary>
        [JsonProperty("resultReview")]
        public ReviewAction ResultReview { get; set; }
    }
}
