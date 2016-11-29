// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace JsonLD.Schema
{
    using DateTimeOffset = System.DateTimeOffset;
    using JsonProperty = Newtonsoft.Json.JsonPropertyAttribute;

    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object.
    /// Optionally happens at a location with the help of an inanimate instrument. The execution
    /// of the action may produce a result. Specific action sub-type documentation specifies
    /// the exact expectation of each argument/role.
    /// http://schema.org/Action
    /// </summary>
    public class Action : Thing
    {
        /// <summary>
        /// Indicates the current disposition of the Action.
        /// </summary>
        [JsonProperty("actionStatus")]
        public ActionStatusType? ActionStatus { get; set; }

        /// <summary>
        /// The direct performer or a driver of the action (animate or inanimate). E.g. John
        /// wrote a book.
        /// </summary>
        [JsonProperty("agent")]
        public OneOf<Organization, Person> Agent { get; set; }

        /// <summary>
        /// The endTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), 
        /// the time that it is expected to end. For actions that span a period of time, when 
        /// the action was performed. e.g. John wrote a book from January to December.
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when 
        /// describing dates with times.This situation may be clarified in future revisions.
        /// </summary>
        [JsonProperty("endTime")]
        public DateTimeOffset? EndTime { get; set; }

        /// <summary>
        /// For failed actions, more information on the cause of the failure.
        /// </summary>
        [JsonProperty("error")]
        public Thing Error { get; set; }

        /// <summary>
        /// The object that helped the agent perform the action. E.g. Join wrote a book
        /// with a pen.
        /// </summary>
        [JsonProperty("instrument")]
        public Thing Instrument { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an organization is
        /// located, or where an action takes place.
        /// </summary>
        [JsonProperty("location")]
        public OneOf<Place, PostalAddress, string> Location { get; set; }

        /// <summary>
        /// The object upon the action is carried out, whose state is kept intact or changed.
        /// Also known as the semantic roles patient, affect or undergoer (which change their
        /// state) or theme (which doesn't). E.g. Join read a book.
        /// </summary>
        [JsonProperty("object")]
        public Thing Object { get; set; }

        /// <summary>
        /// Other co-agents that participated in the action indirectly. E.g. Join wrote a 
        /// book with Steve.
        /// </summary>
        [JsonProperty("participant")]
        public OneOf<Organization, Person> Participant { get; set; }

        /// <summary>
        /// The result produced in the action. E.g. John wrote a book.
        /// </summary>
        [JsonProperty("result")]
        public Thing Result { get; set; }

        /// <summary>
        /// The startTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), 
        /// the time that it is expected to start. For actions that span a period of time, 
        /// when the action was performed. e.g. John wrote a book from January to December.
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when 
        /// describing dates with times.This situation may be clarified in future revisions.
        /// </summary>
        [JsonProperty("startTime")]
        public DateTimeOffset? StartTime { get; set; }

        /// <summary>
        /// Indicates a target <see cref="EntryPoint"/> for an <see cref="Action"/>
        /// </summary>
        [JsonProperty("target")]
        public EntryPoint Target { get; set; }
    }
}
