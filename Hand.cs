namespace PokerFace {

    public abstract class Hand {
        
        //For calculating winnings.
        public virtual uint Multiplier { get; protected set; }

        //Returns whether or not given hand meets requirements to be a specific hand
        public abstract bool IsHand(PlayerHand ph);

        //For on screen print outs.
        public new abstract string ToString();

    }

}
