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
    public partial class Reward : Form {
        public Reward(ulong reward) {
            InitializeComponent();
            lblMessage.Text = $"You have earned a reward of {reward} for your daily login. " +
                $"Login again tomorrow for more, you filthy freeloader.";
        }

        private void btnOk_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
