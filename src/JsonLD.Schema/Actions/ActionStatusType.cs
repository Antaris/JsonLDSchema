// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace JsonLD.Schema
{
    /// <summary>
    /// The status of an <see cref="Action"/>.
    /// http://schema.org/ActionStatusType
    /// </summary>
    public enum ActionStatusType
    {
        /// <summary>
        /// An in-progress action (e.g, while watching the movie, or driving to a location).
        /// </summary>
        Active,

        /// <summary>
        /// An action that has already taken place.
        /// </summary>
        Completed,

        /// <summary>
        /// An action that failed to complete. The action's error property and the HTTP 
        /// return code contain more information about the failure.
        /// </summary>
        Failed,

        /// <summary>
        /// A description of an action that is supported.
        /// </summary>
        Potential
    }
}
