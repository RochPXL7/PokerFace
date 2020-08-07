using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerFace {

    public class Pair : Hand {

        public Pair() {
            Multiplier = 2;
        }

        public override bool IsHand(PlayerHand ph) {
            return DeterminePair(ph);
        }

        public override string ToString() {
            return "Pair";
        }

        protected virtual bool DeterminePair(PlayerHand ph) {
            bool isPair = false;
            for (int i = 1; i < 5; i++) {
                if (ph[i].Number == ph[i - 1].Number) {
                    if (ph[i].Number >= 11) {
                        isPair = true;
                        break;
                    }
                }
            }

            return isPair;
        }

    }

}
