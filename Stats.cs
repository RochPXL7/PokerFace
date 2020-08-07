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
    public partial class Stats : Form {
        public Stats() {
            InitializeComponent();
            lblLosses.Text += Program.user.Losses.ToString();
            lblMoney.Text += Program.user.Money.ToString();
            lblWinnings.Text += Program.user.Winnings.ToString();
            lblWins.Text += Program.user.Wins.ToString();
        }
    }
}
