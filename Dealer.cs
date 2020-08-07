using System;

namespace PokerFace {

    public class Dealer {

        //IDE being obnoxious again
#pragma warning disable IDE0044 // Add readonly modifier
        private Deck _deck;
        private int _index;
        private Pair _pair;
        private TwoPair _twoPair;
        private ThreeOfAKind _three;
        private Straight _straight;
        private FourOfAKind _four;
        private Flush _flush;
        private FullHouse _fullHouse;
        private StraightFlush _straightFlush;
        private RoyalFlush _royalFlush;
        private Hand[] _hands;
#pragma warning restore IDE0044 // Add readonly modifier


        public Dealer() {
            _deck = new Deck();
            _pair = new Pair();
            _twoPair = new TwoPair();
            _three = new ThreeOfAKind();
            _straight = new Straight();
            _flush = new Flush();
            _fullHouse = new FullHouse();
            _four = new FourOfAKind();
            _straightFlush = new StraightFlush();
            _royalFlush = new RoyalFlush();
            _hands = new Hand[] {_royalFlush,_straightFlush,_four,_fullHouse,_flush,_straight,_three,_twoPair,_pair};
        }

        //Initiates the first part of the game
        public Card[] DealHand() {
            Card[] cs = new Card[5];
            for (_index = 0; _index < 5; _index++) {
                cs[_index] = _deck[_index];
            }
            return cs;
        }

        //Initiates the second part of the game
        public Card[] ReplaceCards(int cardsHeld) {
            Card[] cs = new Card[5 - cardsHeld];
            for (_index = 5; _index < 10 - cardsHeld; _index++) {
                cs[_index - 5] = _deck[_index];
            }
            _deck.Reset();
            _index = 0;
            return cs;

        }

        //Returns a Hand instance or null depending on what the highest valid hand is
        public Hand DetermineHand(PlayerHand ph) {
            foreach (Hand h in _hands) {
                if (h.IsHand(ph)) {
                    return h;
                }
            }
            return null;
        }

    }

}