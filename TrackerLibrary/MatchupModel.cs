using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class MatchupModel
    {
        public List<MatchupEntryModel> Entries = new List<MatchupEntryModel>();
        public TeamModel winner;
        public int rounds;
    }
}
