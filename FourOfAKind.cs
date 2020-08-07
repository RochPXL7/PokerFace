using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerFace {

    public class FourOfAKind : Hand {

        public FourOfAKind() {
            Multiplier = 150;
        }

        public override bool IsHand(PlayerHand ph) {
            return DetermineHand(ph);
        }

        public override string ToString() {
            return "Four Of A Kind";
        }

        private bool DetermineHand(PlayerHand ph) {
            bool isFOAK = false;

            int n = 1;
            for (int i = 1; i < 5; i++) {
                if (ph[i].Number == ph[i - 1].Number) {
                    n++;
                    if (n == 4) {
                        isFOAK = true;
                        break;
                    }
                } else {
                    n = 1;
                }
            }

            return isFOAK;
        }

    }

}
