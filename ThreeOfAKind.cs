using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerFace {

    public class ThreeOfAKind : Hand {

        public ThreeOfAKind() {
            Multiplier = 10;
        }

        public override bool IsHand(PlayerHand ph) {
            return DetermineHand(ph);
        }

        public virtual bool DetermineHand(PlayerHand ph) {
            bool isThree = false;
            int n = 1;
            for (int i = 1; i < 5; i++) {
                if (ph[i].Number == ph[i - 1].Number) {
                    n++;
                    if (n == 3) {
                        isThree = true;
                        break;
                    }
                } else {
                    n = 1;
                }
            }

            return isThree;
        }

        public override string ToString() {
            return "Three Of A Kind";
        }
    }

}
