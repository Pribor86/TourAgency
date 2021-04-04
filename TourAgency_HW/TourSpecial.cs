using System;
namespace TourAgency_HW
{
    class TourSpecial: Tour
    {
        int discount;
        int minOfTourist;

        public int Discount { get => discount;  }
        public int MinOfTourist { get => minOfTourist; }

        public TourSpecial(int discount, int minOfTourist, string nameTour,
            int durationTour, double priceTour, int maxOfTourist)
            :base(nameTour, durationTour, priceTour, maxOfTourist)
        {
            this.discount = discount;
            this.minOfTourist = minOfTourist;
        }

        

        public override string ToString()
        {
            return base.ToString() + String.Format("Discount: {0}\nMinimum passangers: {1}", discount, minOfTourist);
        }
    }
}
