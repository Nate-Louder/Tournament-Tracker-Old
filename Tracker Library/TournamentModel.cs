using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{

    /// <summary>
    /// Represents one Tournament.
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of the tournament.
        /// </summary>
        /// <value></value>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the fee a team has to pay to be entered in the tournamnet.
        /// </summary>
        /// <value></value>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents a list of the teams in the particular tournament.
        /// </summary>
        /// <value></value>
        public List<TeamModel> EnteredTeams { get; set; }

        /// <summary>
        /// Represents a list of prizes teams recieve based on their position at the end of the tournament.
        /// Is either percentage of collected fees, or a solid dolar amount.
        /// </summary>
        /// <value></value>
        public List<PrizeModel> Prizes { get; set; }

        /// <summary>
        /// Represents a list of matchup lists.
        /// Each matchup list is a single round with 2 teams in each matchup.
        /// This list is a collection of those lists/rounds.
        /// Includes every matchup in the tournament.
        /// </summary>
        /// <value></value>
        public List<List<Matchup>> Rounds { get; set; }
    }
}