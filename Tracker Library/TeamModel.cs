using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one Team.
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Represents a list of the people on the team
        /// </summary>
        /// <typeparam name="PersonModel"></typeparam>
        /// <returns></returns>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Represents the name of the team
        /// </summary>
        /// <value></value>
        public string TeamName { get; set; }


    }
}