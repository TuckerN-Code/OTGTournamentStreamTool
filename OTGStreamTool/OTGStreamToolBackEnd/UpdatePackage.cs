using System;
using System.Collections.Generic;
using System.Text;

namespace OTGStreamToolBackEnd
{
    public class UpdatePackage
    {
        public string Player1Tag { get; set; }
        public string Player1Prefix { get; set; }
        public string Player1Twitter { get; set; }
        public string Player1Pronouns { get; set; }

        public string Player2Tag { get; set; }
        public string Player2Prefix { get; set; }
        public string Player2Twitter { get; set; }
        public string Player2Pronouns { get; set; }

        public string TournamentRound { get; set; }
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }

    }
}
