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
    public partial class Result : Form {

        private readonly string[] _loss = new string[] {
        "YOU GET NOTHING! YOU LOSE! GOOD DAY SIR!",
        "Oof.", 
        "What hand were you even trying to get?",
        "Damn, you JUST missed a pair, and two pairs, and three of a kind, and a straight, and...",
        "You have won (null)",
        "It's like winning, but in reverse.",
        "Have you tried card counting?",
        "You have won a trillion dollars! Hit alt+f4 to claim your prize!",
        "You gotta pump those numbers up, those are rookie numbers.",
        "Wow. This is worthless!",
        "But wait! I have a high card!",
        "Well, you did have a better hand than your opponents.",
        "Heads I win, tails you lose.",
        "Sike.",
        "Well, at least I know you're not cheating.",
        "hahahahahahahahaha",
        "May the odds be never in your favour.",
        "THAT'S A LOT OF DAMAGE",
        "WHAT DID YOU JUST SAY ABOUT ME YOU LITTLE...\nread more",
        "I'm never gonna financially recover from this."
        };

        private readonly string[] _winMessage = new string[] {
            "Lucky...",
            "DAMN BRO.",
            "CONGRATURATIONS.",
            "Took you long enough.",
            "I like money.",
            "You are winner.",
            "Gambling 100.",
            "I see this as an absolute win.",
            "Buy gold.",
            "Mission Passed!\nRespect+",
            "oh god I still have to write 10 more of these",
            "WOMBO COMBO",
            "money += winningsAmount",
            "coolcoolcoolcoolcoolcoolcoolcoolcool",
            "Congratulations, you have won 1 fake moneys.",
            "task failed successfully.",
            "I would have won if you hadn't beat me.",
            "\"I'm gonna quit my job and buy a yacht!\"",
            "Are ya winning, son?",
            "Beginner's luck"
        };

        private bool _win;

        public Result(Hand h, ulong winnings) {
            InitializeComponent();
            _win = !(h is null);
            Random r = new Random();
            int n = r.Next(0, _loss.Length - 1);
            if (_win) {
                lblNote.Text = $"{_winMessage[n]}\n\nYou got a {h.ToString()} and won {winnings}.";
            } else {
                lblNote.Text = $"{_loss[n]}\n\nYou lost the round.";
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Result_Load(object sender, EventArgs e) {

        }

        private void btnOk_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
