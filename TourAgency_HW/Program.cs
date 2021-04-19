using System;

namespace TourAgency_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            TourList tourList = new TourList();
            Tour tr1 = new Tour("Saaremaa", 25, 150, 40);
            Tour tr2 = new Tour("Hiiumaa", 10, 10, 50);
            Tour tr3 = new Tour("Viljandi", 10, 150, 20);
            Tour tr4 = new Tour("Muhu", 10, 150, 30);
            Tour tr5 = new Tour("Parnu", 10, 150, 35);
            Tour tr6 = new Tour("SPB", 10, 150, 40);
            TourSpecial trsp1 = new TourSpecial("Paide", 15, 100, 5);
            TourSpecial trsp2 = new TourSpecial("Loitsu", 40, 200, 15);
            tourList.AddTour(trsp1);
            tourList.AddTour(trsp2);
            tourList.AddTour(tr1);
            tourList.AddTour(tr2);
            tourList.AddTour(tr3);
            tourList.AddTour(tr4);
            tourList.AddTour(tr5);
            tourList.AddTour(tr6);
            Console.WriteLine("**************************************");
            Console.WriteLine(tourList);
            Console.WriteLine("**************************************");

            Console.WriteLine(tr1.CheckTour(50));
            Console.WriteLine(tr1.PriceOfGroupp(10));
            Console.WriteLine(tr1.nameTour);
            Console.WriteLine(tr2.maxOfTourist);
            Console.WriteLine(tr3.durationTour);
            Console.WriteLine(tr4.priceTour);
            Console.WriteLine(tr1.priceTour(200));

            //tour.nameTour();

            //Console.WriteLine(tr1.PriceAlone());
            //Console.WriteLine(tr1.PriceOfGroupp(15));
            //tr1.PriceOfGroupp(30);

            //Console.WriteLine(tr1.PriceAlone());
            //Console.WriteLine(trsp2.PriceOfGroupp(16));

        }
    }
}
