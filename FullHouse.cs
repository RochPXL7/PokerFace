using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerFace {

    public class FullHouse : Hand {

        public FullHouse() {
            Multiplier = 50;
        }

        public override bool IsHand(PlayerHand ph) {
            return DetermineHand(ph);
        }

        private bool DetermineHand(PlayerHand ph) {
            bool hasThree = false;
            bool hasPair = false;
            int n = 1;

            for (int i = 1; i < 5; i++) {
                if (ph[i].Number == ph[i - 1].Number) {
                    n++;
                    hasThree = hasThree ? true : n == 3;
                } else {
                    hasPair = hasPair ? true : n == 2;
                    n = 1;
                }
            }
            hasPair = hasPair ? true : n == 2;

            return hasPair && hasThree;
        }

        public override string ToString() {
            return "Full House";
        }

    }

}
