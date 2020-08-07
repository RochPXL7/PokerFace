using System;
using System.Drawing;
using System.Windows.Forms;


namespace PokerFace {
    public partial class Game : Form {

#pragma warning disable IDE0044 // Add readonly modifier
        private Dealer _dealer;
        private int _cardsHeld;
        private PictureBox[] pictureBoxes;
        private CheckBox[] holdButtons;
        private CardImage cardImage; 
        private Card[] cards;
        private int[] locs;
        private ulong _bet;
#pragma warning restore IDE0044 // Add readonly modifier

        public Game() {
            InitializeComponent();
            _dealer = new Dealer();
            pictureBoxes = new PictureBox[] { pbx1, pbx2, pbx3, pbx4, pbx5 };
            holdButtons = new CheckBox[] { tbtnHold1, tbtnHold2, tbtnHold3, tbtnHold4, tbtnHold5 };
            cardImage = new CardImage();
            _cardsHeld = 0;
            cards = new Card[5];
            locs = new int[5];
            txtMoney.Text = Program.user.Money.ToString();
            _bet = 10000;
        }
      
        private void Click_btnRun(object sender, EventArgs e) {
            if (_bet > ulong.Parse(txtMoney.Text)) {
                txtBet.Text = txtMoney.Text;
                _bet = ulong.Parse(txtMoney.Text);
                return;
            }
            SetCards();
            txtBet.Text = _bet.ToString();
            Program.user.Money -= _bet;
            txtMoney.Text = Program.user.Money.ToString();
            btnNewHand.Enabled = false;
            btnReplace.Enabled = true;
            Card[] cs = _dealer.DealHand();
            SetCards(cs);
            cs.CopyTo(cards,0);
        }

        private void SetCards(params Card[] cards) {
            int i = 0;
            foreach (Card c in cards) {
                for (int k = i; k < 5; k++) {
                    if (!pictureBoxes[k].Enabled) {
                        int index = ((int)c.CardSuite * 13) + c.Number - 2;
                        pictureBoxes[k].Image = cardImage[index];
                        pictureBoxes[k].Enabled = true;
                        i = k + 1;
                        break;
                    }
                }
            }
        }

        private void SetCards() {
            for (int i = 0; i < 5; i++) {
                pictureBoxes[i].Image = Properties.Resources._null;
                pictureBoxes[i].Enabled = false;
                holdButtons[i].Enabled = true;
            }
        }

        private void Click_btnReplace(object sender, EventArgs e) {
            ProcessHolds();
            btnNewHand.Enabled = true;
            btnReplace.Enabled = false;
            Card[] cs = _dealer.ReplaceCards(_cardsHeld);
            SetCards(cs);
            for (int i = 0; i < 5 - _cardsHeld; i++) {
                cards[locs[i]] = cs[i];
            }
            _cardsHeld = 0;
            PlayerHand ph = new PlayerHand(cards[0],cards[1],cards[2],cards[3],cards[4]);
            Hand h = _dealer.DetermineHand(ph);

            ulong mon;
            if (h is null) {
                mon = 0;
                Program.user.IncrementLosses();
            } else {
                mon = _bet * h.Multiplier;
                Program.user.IncrementWins();
                Program.user.AddWinnings(mon);
                Program.user.Money += (mon);
            }
            txtMoney.Text = Program.user.Money.ToString();

            btnNewHand.Enabled = false;

            InteractivePause(new TimeSpan(0,0,2));

            btnNewHand.Enabled = true;

            _ = new Result(h, mon) {
                Visible = true,
                TopMost = true,
                Location = this.Location
            };
        }

        private void InteractivePause(TimeSpan length) {
            DateTime start = DateTime.Now;
            TimeSpan restTime = new TimeSpan(20000000);
            while (true) {
                System.Windows.Forms.Application.DoEvents();
                TimeSpan remainingTime = start.Add(length).Subtract(DateTime.Now);
                if (remainingTime > restTime) {
                    System.Diagnostics.Debug.WriteLine(string.Format("1: {0}", remainingTime));
                    System.Threading.Thread.Sleep(restTime);
                } else {
                    System.Diagnostics.Debug.WriteLine(string.Format("2: {0}", remainingTime));
                    if (remainingTime.Ticks > 0)
                        System.Threading.Thread.Sleep(remainingTime);
                    break;
                }
            }
        }

        private void ProcessHolds() {
            int n = 0;
            for (int i = 0; i < 5; i++) {
                if (holdButtons[i].Checked) {
                    _cardsHeld++;
                    holdButtons[i].Checked = false;
                } else {
                    pictureBoxes[i].Image = Properties.Resources._null;
                    pictureBoxes[i].Enabled = false;
                    locs[n] = i;
                    n++;
                }
                holdButtons[i].Enabled = false;
            }
        }

        private void btnMinimum_Click(object sender, EventArgs e) {
            int min = int.Parse(txtMoney.Text);
            int bet = 10000 > min ? min : 10000;

            txtBet.Text = bet.ToString();
            _bet = ulong.Parse(txtBet.Text);
        }

        private void btnTenThousand_Click(object sender, EventArgs e) {
            ulong bet = ulong.Parse(txtBet.Text);
            ulong max = Program.user.Money;
            bet = bet + 10000 > max ? max : bet + 10000;

            txtBet.Text = bet.ToString();
            _bet = ulong.Parse(txtBet.Text);
        }

        private void btnHundredThousand_Click(object sender, EventArgs e) {
            ulong bet = ulong.Parse(txtBet.Text);
            ulong max = Program.user.Money;
            bet = bet + 100000 > max ? max : bet + 100000;

            txtBet.Text = bet.ToString();
            _bet = ulong.Parse(txtBet.Text);
        }

        private void btnMillion_Click(object sender, EventArgs e) {
            ulong bet = ulong.Parse(txtBet.Text);
            ulong max = Program.user.Money;
            bet = bet + 1000000 > max ? max : bet + 1000000;

            txtBet.Text = bet.ToString();
            _bet = ulong.Parse(txtBet.Text);
        }

        private void btnMaximum_Click(object sender, EventArgs e) {
            txtBet.Text = txtMoney.Text;
            _bet = ulong.Parse(txtBet.Text);
        }

        private void btnCustom_Click(object sender, EventArgs e) {
            _ = new Custom() {
                Visible = true,
                TopMost = true,
                Location = this.Location
            };
        }

        private void txtBet_KeyPress(object sender, KeyPressEventArgs e) {
          
        }

        public void SetBet(ulong bet) {
            _bet = bet;
            txtBet.Text = _bet.ToString();
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e) {
            System.IO.File.WriteAllText("res\\User.txt", $"money = {Program.user.Money}\nwinnings = {Program.user.Winnings}\n" +
                $"wins = {Program.user.Wins}\nlosses = {Program.user.Losses}");
        }

        private void btnAuthor_Click(object sender, EventArgs e) {
            _ = new Author() {
                Visible = true,
                TopMost = true,
                Location = this.Location
            };
        }

        private void btnStats_Click(object sender, EventArgs e) {
            _ = new Stats() {
                Visible = true,
                TopMost = true,
                Location = this.Location
            };
        }

        private void btnHelp_Click(object sender, EventArgs e) {
            _ = new Help() {
                Visible = true,
                TopMost = true,
                Location = this.Location
            };
        }
    }
}