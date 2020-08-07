using System.Drawing;

namespace PokerFace {

    public class CardImage {

        private readonly Bitmap[] _cards = new Bitmap[] {
        Properties.Resources._2c,
        Properties.Resources._3c,
        Properties.Resources._4c,
        Properties.Resources._5c,
        Properties.Resources._6c,
        Properties.Resources._7c,
        Properties.Resources._8c,
        Properties.Resources._9c,
        Properties.Resources._10c,
        Properties.Resources._11c,
        Properties.Resources._12c,
        Properties.Resources._13c,
        Properties.Resources._14c,
        Properties.Resources._2s,
        Properties.Resources._3s,
        Properties.Resources._4s,
        Properties.Resources._5s,
        Properties.Resources._6s,
        Properties.Resources._7s,
        Properties.Resources._8s,
        Properties.Resources._9s,
        Properties.Resources._10s,
        Properties.Resources._11s,
        Properties.Resources._12s,
        Properties.Resources._13s,
        Properties.Resources._14s,
        Properties.Resources._2h,
        Properties.Resources._3h,
        Properties.Resources._4h,
        Properties.Resources._5h,
        Properties.Resources._6h,
        Properties.Resources._7h,
        Properties.Resources._8h,
        Properties.Resources._9h,
        Properties.Resources._10h,
        Properties.Resources._11h,
        Properties.Resources._12h,
        Properties.Resources._13h,
        Properties.Resources._14h,
        Properties.Resources._2d,
        Properties.Resources._3d,
        Properties.Resources._4d,
        Properties.Resources._5d,
        Properties.Resources._6d,
        Properties.Resources._7d,
        Properties.Resources._8d,
        Properties.Resources._9d,
        Properties.Resources._10d,
        Properties.Resources._11d,
        Properties.Resources._12d,
        Properties.Resources._13d,
        Properties.Resources._14d};

        public Bitmap this[int i] {
            get {
                return _cards[i];
            }
        }

    }

}
