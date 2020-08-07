using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerFace {

    public class StraightFlush : Hand, IFlush, IStraight {

        public StraightFlush() {
            Multiplier = 300;
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

        public bool DetermineStraight(PlayerHand ph) {
            bool isStraight = true;
            for (int i = 1; i < 5; i++) {
                if (ph[i].Number != ph[i - 1].Number + 1) {
                    isStraight = false;
                    break;
                }
            }

            if (ph[0].Number == 2 && ph[1].Number == 3 && ph[2].Number == 4 && ph[3].Number == 5 && ph[4].Number == 14) {
                isStraight = true;
            }

            return isStraight;
        }

        public override bool IsHand(PlayerHand ph) {
            return DetermineFlush(ph) && DetermineStraight(ph);
        }

        public override string ToString() {
            return "Straight Flush";
        }

    }

}