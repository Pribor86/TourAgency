using System;
namespace TourAgency_HW
{
    class Tour
    {
        public string nameTour { get; }
        public int durationTour { get; }
        public double priceTour { get; set; }
        public int maxOfTourist { get; }

        public Tour(string nameTour, int durationTour, double priceTour, int maxOfTourist)
        {
            this.nameTour = nameTour;
            this.durationTour = durationTour;
            this.priceTour = priceTour;
            this.maxOfTourist = maxOfTourist;
        }

        //public string TourType() //Запросы на данные, если не пойдут просто геттеры
        //{
        //    return nameTour;
        //}

        //public int TourDuration()
        //{
        //    return durationTour;
        //}

        //public double PriceForOne()
        //{
        //    return priceTour;
        //}

        //public int MaximumTourist()
        //{
        //    return maxOfTourist;
        //}

        public double PriceAlone()
        {
            return priceTour * maxOfTourist * 0.85; //Цены для одного человека, если он хочет поехать в тур один(со скидкой 15%)
        }

        public bool CheckTour(int countPeople)
        {
            if (countPeople <= maxOfTourist && countPeople > 0)
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
            if (countPeople <= maxOfTourist && countPeople > 0)
            {

                return countPeople * priceTour;
            }
            else
            {
                CheckTour(countPeople);
                return -1;
                    
            }
        }

        public double SetPriceTour(double price)
        {
            return priceTour = price;
        }



        public override string ToString()
        {
            if (durationTour >= 24)
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
