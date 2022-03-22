using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{

    /// <summary>
    /// Represents one Person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Represents the person's first name
        /// </summary>
        /// <value></value>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents the person's last name
        /// </summary>
        /// <value></value>
        public string LastName { get; set; }

        /// <summary>
        /// Represents the person's email address
        /// </summary>
        /// <value></value>

        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents the person's phone number2
        /// </summary>
        /// <value></value>
        public string PhoneNumber { get; set; }
    }
}