using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerFace {

    public class Flush : Hand, IFlush {

        public Flush() {
            Multiplier = 30;
        }

        public bool DetermineFlush(PlayerHand ph) {
            bool isFlush = true;
            for (int i = 1; i < 5; i++) {
                if (ph[i].CardSuite != ph[i - 1].CardSuite) {
                    isFlush = false;
                    break;
                }
            }
            return isFlush;
        }

        public override bool IsHand(PlayerHand ph) {
            return DetermineFlush(ph);
        }

        public override string ToString() {
            return "Flush";
        }
    }

}
