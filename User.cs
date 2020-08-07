using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerFace {

    public class User {

        public ulong Money { get; set; }

        public int Wins { get; private set; }

        public int Losses { get; private set; }

        public ulong Winnings { get; private set; }

        public void IncrementWins() {
            Wins++;
        }

        public void IncrementLosses() {
            Losses++;
        }

        public void AddWinnings(ulong val) {
            Winnings += val;
        }

        public User() : this(0,0,0,0) {

        }

        public User(ulong money, int wins, int losses, ulong winnings) {
            Money = money;
            Wins = wins;
            Losses = losses;
            Winnings = winnings;
        }

    }

}
