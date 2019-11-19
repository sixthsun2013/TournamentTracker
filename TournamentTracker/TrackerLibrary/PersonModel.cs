﻿namespace TrackerLibrary
{
    /// <summary>
    /// Represents one person
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The first name of the person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the person
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The primary email of the person
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The primary phone number of the person
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}