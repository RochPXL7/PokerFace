using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerFace {

    public class RoyalFlush : StraightFlush {

        public RoyalFlush() {
            Multiplier = 600;
        }

        public override string ToString() {
            return "Royal Flush";
        }

        public override bool IsHand(PlayerHand ph) {
            bool isSF = base.IsHand(ph);
            return ph[0].Number == 10 && isSF;
        }

    }

}
