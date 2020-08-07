using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerFace {

    public class PlayerHand {

        private Card[] _cards;

        public Card this[int i] {
            get {
                return _cards[i];
            }
        }

        public PlayerHand(Card c0, Card c1, Card c2, Card c3, Card c4) {
            _cards = new Card[] {c0,c1,c2,c3,c4};

            Card temp;
            for (int i = 0; i < 5; i++) {
                Card max = _cards[0];
                int maxIndex = 0;
                int l = 5 - i;
                for (int k = 1; k < l; k++) {
                    if (_cards[k] > max) {
                        maxIndex = k;
                        max = _cards[k];
                    }
                }
                if (maxIndex != (l - 1)) {
                    temp = _cards[l - 1];
                    _cards[l - 1] = max;
                    _cards[maxIndex] = temp;
                }
            }
        }

    }

}
