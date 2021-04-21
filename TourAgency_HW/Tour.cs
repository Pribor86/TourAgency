using System;
namespace TourAgency_HW
{
    class Tour
    {
        public string NameTour { get; }
        public int DurationTour { get; }
        public double PriceTour { get; set; }
        public int MaxOfTourist { get; }

        public Tour(string nameTour, int durationTour, double priceTour, int maxOfTourist)
        {
            this.NameTour = nameTour;
            this.DurationTour = durationTour;
            this.PriceTour = priceTour;
            this.MaxOfTourist = maxOfTourist;
        }

        //public string TourType() //Запросы на данные, если не пойдут просто геттеры
        //{
        //    return NameTour;
        //}

        //public int TourDuration()
        //{
        //    return DurationTour;
        //}

        //public double PriceForOne()
        //{
        //    return PriceTour;
        //}

        //public int MaximumTourist()
        //{
        //    return MaxOfTourist;
        //}

        public double PriceAlone()
        {
            return PriceTour * MaxOfTourist * 0.85; //Цены для одного человека, если он хочет поехать в тур один(со скидкой 15%)
        }

        public bool CheckTour(int countPeople)
        {
            if (countPeople <= MaxOfTourist && countPeople > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public virtual double PriceOfGroupp(int countPeople)
        {
            if (countPeople <= MaxOfTourist && countPeople > 0)
            {

                return countPeople * PriceTour;
            }
            else
            {
                CheckTour(countPeople);
                return -1;
                    
            }
        }

        public double SetPriceTour(double price)
        {
            return PriceTour = price;
        }



        public override string ToString()
        {
            if (DurationTour >= 24)
            {
                int days;
                int hours;
                days = DurationTour / 24;
                hours = DurationTour % 24;

                return String.Format("Tour name: {0}\nTour duration: {1}d {2}h\nTour price: {3}\nMaximum tourist: {4}\n"
                    , NameTour, days, hours, PriceTour, MaxOfTourist);
            }
            else
            {
                return String.Format("Tour name: {0}\nTour duration: {1}\nTour price: {2}\nMaximum tourist: {3}\n"
                        , NameTour, DurationTour, PriceTour, MaxOfTourist);
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Tour tour &&
                   NameTour == tour.NameTour &&
                   DurationTour == tour.DurationTour &&
                   PriceTour == tour.PriceTour &&
                   MaxOfTourist == tour.MaxOfTourist;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(NameTour, DurationTour, PriceTour, MaxOfTourist);
        }
    }
}
