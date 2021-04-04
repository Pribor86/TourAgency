using System;
namespace TourAgency_HW
{
    class Tour
    {
        private string nameTour;
        private int durationTour;
        private double priceTour;
        private int maxOfTourist;

        protected string NameTour { get => nameTour;  }
        protected int DurationTour { get => durationTour;  }
        protected double PriceTour { get => priceTour; }
        protected int MaxOfTourist { get => maxOfTourist;  }

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
            return String.Format("Tour name: {0}\nTour duration: {1}\nTour price: {2}\nMaximum tourist: {3}"
                , NameTour, DurationTour, PriceTour, MaxOfTourist);
        }
    }
}
