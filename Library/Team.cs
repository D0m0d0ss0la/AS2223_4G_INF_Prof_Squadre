using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Team
    {
        string name;

        /// <summary>
        /// List of players of the Team
        /// </summary>
        List<Player> players = new List<Player>();

        /// <summary>
        /// Team captain
        /// </summary>
        Player? captain;
        
        /// <summary>
        /// Maximum number of players for each role
        /// </summary>
        const int MAX_RISERVA_PLAYERS = 3;
        const int MAX_ROSA_PLAYERS = 11;

        public Team(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Adding player to a Team
        /// 
        /// We can have a maximum of MAX_ROSA_PLAYERS rosa's players and MAX_RISERVA_PLAYERS riserva's player
        /// </summary>
        /// <param name="player"></param>
        /// <returns>True if player has been inserted</returns>
        public bool AddPlayer(Player player)
        {
            string role = Convert.ToString(player.Role);
            if(role == "Rosa" && MAX_ROSA_PLAYERS >= players.Count)
            {
                players.Add(player);
                return true;
            }
            if(role == "Riserva" && players.Count <= MAX_RISERVA_PLAYERS + MAX_ROSA_PLAYERS)
            {
                players.Add(player);
                return true;
            }
            return false;
            
            
        }

        /// <summary>
        /// Setting captain of the Team
        /// 
        /// Captain must be in the Rosa role
        /// </summary>
        /// <param name="captain"></param>
        /// <returns>True if captain has been setted</returns>
        public bool AddCaptain(Player captain)
        {
            this.captain = captain;
            players.Add(this.captain);
            return true;
        }

        /// <summary>
        /// Get a list of players of the team
        /// </summary>
        /// <returns></returns>
        public string GetPlayers()
        {
            string playerListPlus = "";
            foreach (Player player in players)
            {
                    Console.WriteLine(player.Description());
            }
            return "";
                }

        public string Name { get { return name; } }

        public Player? Captain { get { return captain; } }
    }
}
