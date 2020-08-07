using System;
using System.Runtime.CompilerServices;

namespace PokerFace {

	public class Card {
		
		public enum Suite {CLUBS, SPADES, HEARTS, DIAMONDS}
		public Suite CardSuite{ get; }
		public int Number { get; }

		public Card(Suite suite, int num) {
			if (num < 2 || num > 14) {
				num = 14;
            }
			Number = num;
			CardSuite = suite;
		}

		//Overrides from System.Object

		//Convenience method for == overload
        public override bool Equals(object obj) {
			if (obj is Card c) {
				if (c.CardSuite == this.CardSuite && c.Number == this.Number) {
					return true;
				} else {
					return false;
				}
			} else {
				return false;
			}
		}

		//Outdated, decided not to remove
		public override string ToString() {
			string toString = "";

			if (this.CardSuite == Suite.CLUBS) {
				toString = Number.ToString() + "c" + ".png";
			} else if (this.CardSuite == Suite.DIAMONDS) {
				toString = Number.ToString() + "d" + ".png";
			} else if (this.CardSuite == Suite.SPADES) {
				toString = Number.ToString() + "s" + ".png";
			} else if (this.CardSuite == Suite.HEARTS) {
				toString = Number.ToString() + "h" + ".png";
			}

			return toString;
		}

		//The IDE was complaining that I didn't implement GetHashCode(). That's the only reason this exists.
		public override int GetHashCode() {
			return base.GetHashCode();
		}

		//Operator overloads; I thought I needed these more than I did
		public static bool operator >(Card c1, Card c2) {
			return c1.Number > c2.Number;
        }

		public static bool operator >=(Card c1, Card c2) {
			return c1.Number >= c2.Number;
        }

		public static bool operator <(Card c1, Card c2) {
			return c1.Number < c2.Number;
		}

		public static bool operator <=(Card c1, Card c2) {
			return c1.Number <= c2.Number;
		}

		public static bool operator ==(Card c1, Card c2) {
			if (c1 is null) {
				if (c2 is null) {
					return true;
				}
				return false;
			}
			return c1.Equals(c2);
		}

		public static bool operator !=(Card c1, Card c2) {
			return !(c1 == c2);
		}

	}

}