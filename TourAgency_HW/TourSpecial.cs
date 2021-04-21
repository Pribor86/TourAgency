using System;
namespace TourAgency_HW
{
    class TourSpecial: Tour
    {
        static double Discount { get; } = 10;
        int MinOfTourist { get; set; } = 10;

        

        public TourSpecial(string nameTour,
            int durationTour, double priceTour, int maxOfTourist)
            :base(nameTour, durationTour, priceTour, maxOfTourist)
        {
            DiscountCheck();
        }

        public int DiscountCheck()
        {
            if (MinOfTourist > MaxOfTourist)
            {
                return MinOfTourist = MaxOfTourist;
            }
            else
            {
                return MinOfTourist;
            }
        }

        public override double PriceOfGroupp(int countPeople)
        {
            if(countPeople >= MinOfTourist && countPeople <= MaxOfTourist)
            {
                return ((countPeople * PriceTour) - ((countPeople * PriceTour) * Discount / 100));
            }
            else
            {
                DiscountCheck();
                return -1;
            }
        }

        

        public override string ToString()
        {
            return base.ToString() + String.Format("Discount: {0}% if passanger count minimum {1}", Discount, MinOfTourist);
        }
    }
}
