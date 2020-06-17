/*
    Created by: Ivo Tasevski
    * Player class - this class describes the user attributes, gamertag and score.
    * Last revised: 17.06.2020
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Minute_Sniper
{
    public class Player
    {
        public String player_gamertag { get; set; }
        public int player_highscore { get; set; }


        public Player(String gamertag, int highscore)
        {
            this.player_gamertag = gamertag;
            this.player_highscore = highscore;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", player_gamertag, player_highscore);
        }

    }
}
