using System;
namespace TourAgency_HW
{
    class Tour
    {
        protected string nameTour;
        protected int durationTour;
        protected double priceTour;
        protected int maxOfTourist;

        public string NameTour { get => nameTour;  }
        public int DurationTour { get => durationTour;  }
        public double PriceTour { get => priceTour; }
        public int MaxOfTourist { get => maxOfTourist;  }

        public Tour(string nameTour, int durationTour, double priceTour, int maxOfTourist)
        {
            this.nameTour = nameTour;
            this.durationTour = durationTour;
            this.priceTour = priceTour;
            this.maxOfTourist = maxOfTourist;
        }

        public string TourType()
        {
            return NameTour;
        }

        public int TourDuration()
        {
            return DurationTour;
        }

        public double PriceForOne()
        {
            return priceTour;
        }

        public int MaximumTourist()
        {
            return MaxOfTourist;
        }

        public double PriceAlone()
        {
            return priceTour * maxOfTourist * 0.85;
        }

        public bool CheckTour(int countPeople)
        {
            if (countPeople < maxOfTourist)
            {
                return true;
            }
            else
                return false;
            
        }

        public void PriceOfGroupp(int countPeople)
        {
            if (countPeople < maxOfTourist)
            {

                Console.WriteLine(countPeople * priceTour);
            }
            else
            {
                Console.WriteLine(CheckTour(countPeople));
            }
        }




        public override string ToString()
        {
            if (durationTour > 24)
            {
                int days;
                int hours;
                days = durationTour / 24;
                hours = durationTour % 24;

                return String.Format("Tour name: {0}\nTour duration: {1}d {2}h\nTour price: {3}\nMaximum tourist: {4}\n"
                    , nameTour, days, hours, priceTour, maxOfTourist);
            }
            else
            {
                return String.Format("Tour name: {0}\nTour duration: {1}\nTour price: {2}\nMaximum tourist: {3}\n"
                        , nameTour, durationTour, priceTour, maxOfTourist);
            }
        }
    }
}
