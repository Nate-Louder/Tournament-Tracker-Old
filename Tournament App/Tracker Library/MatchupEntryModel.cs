using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents a Team and their properties within a matchup against another team.
    /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        /// <value></value>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this particular team
        /// </summary>
        /// <value></value>
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchup that this particular team came from as the winner.
        /// </summary>
        /// <value></value>
        public MatchupModel ParentMatchup { get; set; }
    }
}
