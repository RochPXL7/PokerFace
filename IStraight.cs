using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerFace {

    public interface IStraight {

        //For... Determining straights.
        bool DetermineStraight(PlayerHand ph);

    }

}
