using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PokerFace {
    static class Program {

        public static Game game;
        public static User user;

        [STAThread]
        static void Main() {
            LoadUser();
            bool reward = Login();
            ulong r = 0;
            if (reward) {
                r = 500000 + (ulong)(0.015 * user.Money);
                user.Money += r;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            game = new Game();
            if (reward) {
                _ = new Reward(r) {
                    Visible = true,
                    TopMost = true,
                };
            }
            Application.Run(game);
        }

        private static bool Login() {
            bool loginReward = false;
            string log = "";
            try {
                log = System.IO.File.ReadAllText("res\\Login.txt");
                string[] logs = log.Split('\n');
                DateTime[] dates = new DateTime[logs.Length - 1];
                int i = 0;
                foreach (string l in logs) {
                    if (l == "") {
                        break;
                    }
                    string[] tokens = l.Split(',');
                    int year = int.Parse(tokens[0]);
                    int month = int.Parse(tokens[1]);
                    int day = int.Parse(tokens[2]);

                    dates[i] = new DateTime(year, month, day);
                    i++;
                }

                DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                DateTime[] sortDates = SortDates(sortDates: dates); //haha I said sort and date a lot
                if (today > sortDates[sortDates.Length - 1]) {
                    loginReward = true;
                } else {
                    loginReward = false;
                }
            } catch (System.IO.FileNotFoundException) {
                loginReward = true;
            } finally {
                log += $"{DateTime.Today.Year},{DateTime.Today.Month},{DateTime.Today.Day}\n";
                System.IO.File.WriteAllText("res\\Login.txt", log);
            }

            return loginReward;
        }

        private static DateTime[] SortDates(DateTime[] sortDates) {
            for (int i = 0; i < sortDates.Length; i++) {
                DateTime max = sortDates[0];
                int loc = 0;
                for (int k = 0; k < sortDates.Length - i; k++) {
                    if (sortDates[k] > max) {
                        max = sortDates[k];
                        loc = k;
                    }
                    sortDates[loc] = sortDates[sortDates.Length - i - 1];
                    sortDates[sortDates.Length - i - 1] = max;
                }            
            }

            return sortDates;
        }

        private static void LoadUser() {
            string useString;
            try {
                useString = System.IO.File.ReadAllText("res\\User.txt");
            } catch (Exception) {
                user = new User();
                return;
            }
            string[] lines = useString.Split('\n');
            ulong money = 1000000, winnings = 0;
            int wins = 0, losses = 0;
            foreach (string line in lines) {
                string[] tokens = line.Split('=');
                tokens[0] = tokens[0].Trim();
                tokens[1] = tokens[1].Trim();
                if (tokens[0] == "money") {
                    money = ulong.Parse(tokens[1]);
                } else if (tokens[0] == "winnings") {
                    winnings = ulong.Parse(tokens[1]);
                } else if (tokens[0] == "wins") {
                    wins = int.Parse(tokens[1]);
                } else if (tokens[0] == "losses") {
                    losses = int.Parse(tokens[1]);
                }
            }

            user = new User(money, wins, losses, winnings);
        }
    }
}
