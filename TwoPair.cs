using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerFace {

    public class TwoPair : Pair {
        
        public TwoPair() {
            Multiplier = 5;
        }

        public override bool IsHand(PlayerHand ph) {
            return DeterminePair(ph);
        }

        protected override bool DeterminePair(PlayerHand ph) {
            bool isPair = false;
            int pairs = 0;
            for (int i = 1; i < 5; i++) {
                if (ph[i].Number == ph[i - 1].Number) {
                    pairs++;
                }
            }

            if (pairs == 2) {
                isPair = true;
            }

            return isPair;
        }

        public override string ToString() {
            return "Two Pairs";
        }

    }

}
