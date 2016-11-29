// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace JsonLD.Schema
{
    using JsonProperty = Newtonsoft.Json.JsonPropertyAttribute;
    using Uri = System.Uri;

    /// <summary>
    /// The most generic type of item.
    /// http://schema.org/Thing
    /// </summary>
    public class Thing
    {
        /// <summary>
        /// An additional type for the item, typically used for adding more specific types 
        /// from external vocabularies in microdata syntax. This is a relationship between 
        /// something and a class that the thing is in. In RDFa syntax, it is better to use 
        /// the native RDFa syntax - the 'typeof' attribute - for multiple types. 
        /// Schema.org tools may have only weaker understanding of extra types, in particular 
        /// those defined externally.
        /// </summary>
        [JsonProperty("additionalType")]
        public Uri AdditionalType { get; set; }

        /// <summary>
        /// An alias for the item.
        /// </summary>
        [JsonProperty("alternateName")]
        public string AlternateName { get; set; }

        /// <summary>
        /// A description of the item.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// A sub property of description. A short description of the item used to 
        /// disambiguate from other, similar items. Information from other properties 
        /// (in particular, name) may be necessary for the description to be useful for 
        /// disambiguation.
        /// </summary>
        [JsonProperty("disambiguatingDescription")]
        public string DisambiguatingDescription { get; set; }

        /// <summary>
        /// An image of the item. This can be a <see cref="Uri"/> or a fully described 
        /// <see cref="ImageObject"/>. 
        /// </summary>
        [JsonProperty("image")]
        public OneOf<ImageObject, Uri> Image { get; set; }

        /// <summary>
        /// Indicates a page (or other <see cref="CreativeWork"/>) for which this thing is 
        /// the main entity being described.
        /// </summary>
        [JsonProperty("mainEntityOfPage")]
        public OneOf<CreativeWork, Uri> MainEntityOfPage { get; set; }

        /// <summary>
        /// The name of the item.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Indicates a potential Action, which describes an ideaized action in which this
        /// thing would play an 'object' role.
        /// </summary>
        [JsonProperty("potentialAction")]
        public Action PotentialAction { get; set; }

        /// <summary>
        /// Uri of a reference Web page that unabiguously indicates the item's identity. E.g.
        /// the Uri of the item's Wikipedia page, Freebase page or official website.
        /// </summary>
        [JsonProperty("sameAs")]
        public Uri SameAs { get; set; }

        /// <summary>
        /// Uri of the item.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}
