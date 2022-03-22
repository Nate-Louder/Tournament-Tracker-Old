using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{

    /// <summary>
    /// Represents one prize.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Represents the place that the prize would go to.
        /// In integer form. 1 is best, largest number is worst.
        /// </summary>
        /// <value></value>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the name asscosiated with the place number.
        /// Ex. 1 -> "Champion", 2 -> "Finalist"
        /// </summary>
        /// <value></value>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the amount in dolars that the reciver of the prize would recive.
        /// If this option is chosen when the prize is created, then percentage cannot be selected.
        /// </summary>
        /// <value></value>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the amount in percentage of pool money that the reciever of the prize would recive.
        /// If this option is chosen when the prize is created, then amount cannot be selected.
        /// </summary>
        /// <value></value>
        public double PrizePercentage { get; set; }

    }
}