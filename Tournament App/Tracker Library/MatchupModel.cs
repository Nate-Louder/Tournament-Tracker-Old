using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{

    /// <summary>
    /// Represents a matchup between 2 teams or a team and a bye.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Represents the two teams cometeing in the matchup.
        /// List contains only two teams at most.
        /// Can contain 1 team if team has a bye and cometes against no one.
        /// </summary>
        /// <value></value>
        public List<MatchupEntryModel> Entries { get; set; }

        /// <summary>
        /// Represents the team with the best score.
        /// Could be high or low based on the sport. Basketball and golf respectively
        /// </summary>
        /// <value></value>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents the round that the matchup is happening in.
        /// </summary>
        /// <value></value>
        public int MatchupRound { get; set; }
    }
}