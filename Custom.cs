using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerFace {
    public partial class Custom : Form {

        private ulong _money;

        public Custom() {
            InitializeComponent();
            _money = Program.user.Money;
        }

        private void btnApply_Click(object sender, EventArgs e) {
            try {
                ulong bet = ulong.Parse(txtBet.Text);
                if ((_money >= 10000 && bet < 10000) || bet > _money) {
                    throw new Exception();
                }
                Program.game.SetBet(bet);
                this.Close();
            } catch (Exception) {
                lblInvalid.Visible = true;
            }
        }
    }
}
