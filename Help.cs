using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerFace {
    public partial class Help : Form {

        private Page[] _pages;
        private int _index;

        struct Page {
            internal string body;
            internal string header;
        }

        public Help() {
            InitializeComponent();
            _index = 0;
            _pages = new Page[4];
            InitPages();
            CoverCheck();
            UpdateLabels();
        }

        private void btnPrevious_Click(object sender, EventArgs e) {
            _index--;
            UpdateLabels();
            CoverCheck();
        }

        private void btnNext_Click(object sender, EventArgs e) {
            _index++;
            UpdateLabels();
            CoverCheck();
        }

        private void CoverCheck() {
            btnPrevious.Enabled = _index != 0;
            btnNext.Enabled = _index != 3;
            lblPrevNum.Visible = _index != 0;
            lblNextNum.Visible = _index != 3;
        }

        private void UpdateLabels() {
            lblBody.Text = _pages[_index].body;
            lblHeader.Text = _pages[_index].header;
            lblPrevNum.Text = _index.ToString();
            lblNextNum.Text = (_index + 2).ToString();
            lblPageNumber.Text = "Page " + (_index + 1).ToString();
        }

        private void InitPages() {
            _pages[0].header = "How to Play";
            _pages[0].body = "Video poker is simply a digitized version of 5 card draw poker. Your goal is to end up " +
                "with 5 cards that represent one of the 9 hands, which are, from least valuable to most valuable, pair " +
                "(in video poker, the pair must be jacks or higher), two pairs, three of a kind, " +
                "straight, flush, full house, four of a kind, straight flush, and the ever elusive royal flush. " +
                "While I will not cover the basics of 5 card draw here, there are plenty of resources online which can do that.\n\n" +
                "Deal a new hand by clicking the 'New Hand' button. To hold a card, click the hold button underneath the card image. " +
                "Deal new cards to replace the ones you are not holding on to by clicking the 'Replace Cards' button. " +
                "The game will deal your cards and then pause to allow you to briefly look at them, then a pop up will appear " +
                "announcing your hand and winnings (or it will mock you if you lost).";
            _pages[1].header = "Money and Winnings";
            _pages[1].body = "This game uses an unnamed fictionalized currency, of which you start with 500000 thanks to the login reward" +
                " (See page 3 for more information about daily login). Money is earned by winning games and logging in daily. " +
                "The minimum bet is 10000, unless you have less than 10000 money in which case that restriction is waived. " +
                "Your winnings for a successful hand are the bet multiplied by a number based on the hand. Here are the multipliers" +
                " associated with each hand:\n" +
                "Pair: 2\n" +
                "Two pairs: 5\n" +
                "Three of a kind: 10\n" +
                "Straight: 20\n" +
                "Flush: 30\n" +
                "Full house: 50\n" +
                "Four of a kind: 150\n" +
                "Straight flush: 300\n" +
                "Royal flush: 600";
            _pages[2].header = "Miscellaneous Features";
            _pages[2].body = "Every new day that you log in, you will receive money to use for gameplay. " +
                "The minimum amount is 500000, and the reward increases based on how much money you have. " +
                "This is intended to incentivise active daily gameplay... Get the hint?\n" +
                "The stats button opens a dialog with various stats, as the name implies. Wins and losses are " +
                "fairly straightforward to understand, money is your current money, and winnings is the total amount " +
                "of money you have won from successful hands.\n" +
                "For the 'About the Author' button, that is information about me, Roch Laferriere. My first name is pronounced the same " +
                "as the word 'rock,' it just has an h in it.\n" +
                "The betting buttons increment the bet by the amount listed. The 'Lose It All' button is all-in. " +
                "The buttons will never exceed the money you have, nor will they dip below 10000 (except for the case listed on page 2).\n" +
                "The custom button opens a pop up, in which you may type in a more specific bet. The pop up will force you to follow " +
                "the aforementioned rules.";
            _pages[3].header = "Credits";
            _pages[3].body = "Head of development: Roch Laferriere\n" +
                "Programming: Roch Laferriere\n" +
                "Graphics: Roch Laferriere\n" +
                "Dialogue and text: Roch Laferriere\n" +
                "Outdated memes: Roch Laferriere\n" +
                "Creative team: Roch Laferriere, Roch Laferriere, and Rochester Lafreniere\n" +
                "Procrastination: Roch Laferriere\n" +
                "Testing and debugging: Roch Laferriere\n\n" +
                "Card images from random.org. Usage of those images falls under fair use (I think). Either way " +
                "I am not profiting off this so whatever.\n" +
                "All code written in C# using the .NET Framework and the Visual Studio IDE. Thanks Microsoft.";
        }
    }
}
