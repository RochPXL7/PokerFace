using System;

namespace PokerFace {

    public class Deck {

        private Card[] _cards;

        //Indexer
        public Card this[int i] {
            get {
                return _cards[i];
            }
        }

        public Deck() {
            _cards = new Card[52];
            InitializeDeck();
            Shuffle();
        }

        //Creates 52 cards and populates the deck
        private void InitializeDeck() {
            int i = 0;
            for (int s = 0; s < 4; s++) {
                for (int n = 2; n <= 14; n++) {
                    _cards[i] = new Card(suite: (Card.Suite)s, num: n);
                    i++;
                }
            }
        }

        //Randomly shuffles the cards using the Fisher Yates algorithm
        private void Shuffle() {
            Random r = new Random();
            int n = _cards.Length;
            for (int i = 0; i < (n - 1); i++) {
                int k = i + r.Next(n - i);
                Card t = _cards[k];
                _cards[k] = _cards[i];
                _cards[i] = t;
            }
        }

        //Resets 
        public void Reset() {
            Shuffle();
        }

    }

}