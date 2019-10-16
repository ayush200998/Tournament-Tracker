using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class TournamentModel
    {
        public String Tournamentname { get; set; }
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        public List<PrizeModel> Prizes = new List<PrizeModel>();
        public List<List<MatchupModel>> Rounds = new List<List<MatchupModel>>();
        public decimal Entryfees { get; set; }
            
    }
}
