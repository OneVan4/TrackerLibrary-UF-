using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public  class MatchupEntryModel
    {
        /// <summary>
        /// Represent one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// represents the score for this particular team
        /// </summary>
        public int score { get; set; }
        /// <summary>
        /// represents the mathcup this team came from as the winner 
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
