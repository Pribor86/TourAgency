using System;
namespace TourAgency_HW
{
    class TourSpecial: Tour
    {
        static double discount = 10;
        int minOfTourist = 10;

        public double Discount { get => discount;  }
        public int MinOfTourist { get => minOfTourist; }

        public TourSpecial(string nameTour,
            int durationTour, double priceTour, int maxOfTourist)
            :base(nameTour, durationTour, priceTour, maxOfTourist)
        {
            if (minOfTourist > maxOfTourist)
            {
                minOfTourist = maxOfTourist;
            }
           
        }

        public double PriceSpecialTour(int countPeople)
        {
            if(countPeople >= minOfTourist && countPeople <= maxOfTourist)
            {
                return ((countPeople * priceTour) - ((countPeople * priceTour) * discount / 100));
            }
            else
            {

                return -1;
            }
        }

        

        public override string ToString()
        {
            return base.ToString() + String.Format("Discount: {0}% if passanger count minimum {1}", discount, minOfTourist);
        }
    }
}
