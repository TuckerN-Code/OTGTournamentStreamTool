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
        public string Player1Score { get; set; }
        public string Player2Score { get; set; }

        public String sendP1Name()
        {
            return Player1Tag;
        }

        public List<string> toList()
        {
            List<string> list = new List<string>();
            list.Add(Player1Tag);
            list.Add(Player1Prefix);
            list.Add(Player1Twitter);
            list.Add(Player1Pronouns);
            list.Add(Player2Tag);
            list.Add(Player2Prefix);
            list.Add(Player2Twitter);
            list.Add(Player2Pronouns);
            list.Add(TournamentRound);
            list.Add(Player1Score);
            list.Add(Player2Score);
            return list;
        }

    }
}
