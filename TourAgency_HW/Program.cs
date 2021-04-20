using System;

namespace TourAgency_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            TourList tourList = new TourList();
            Tour tr1 = new("Saaremaa", 25, 150, 40);
            Tour tr2 = new("Hiiumaa", 10, 10, 50);
            Tour tr3 = new("Viljandi", 10, 150, 20);
            Tour tr4 = new("Muhu", 10, 150, 30);
            Tour tr5 = new("Parnu", 10, 150, 35);
            Tour tr6 = new("SPB", 10, 150, 40);
            Tour tr7 = new("Saaremaa", 25, 150, 40);//tr7 == tr1
            TourSpecial trsp1 = new("Paide", 15, 100, 5);
            TourSpecial trsp2 = new("Loitsu", 40, 200, 15);
            tourList.AddTour(trsp1);
            tourList.AddTour(trsp2);
            tourList.AddTour(tr1);
            tourList.AddTour(tr2);
            tourList.AddTour(tr3);
            tourList.AddTour(tr4);
            tourList.AddTour(tr5);
            tourList.AddTour(tr6);
            tourList.AddTour(tr7);// -> return false
            Console.WriteLine("**************************************");
            Console.WriteLine(tourList);
            Console.WriteLine("**************************************");
            
            Console.WriteLine(tr1.CheckTour(50));//-> false
            Console.WriteLine(tr1.PriceOfGroupp(10));
            Console.WriteLine(tr1.PriceAlone());
            Console.WriteLine(tr1.PriceOfGroupp(15));
            Console.WriteLine(tr1.SetPriceTour(10));
            Console.WriteLine(trsp1.PriceOfGroupp(100));//-> return -1
            Console.WriteLine(tr1.nameTour);
            Console.WriteLine(tr2.maxOfTourist);
            Console.WriteLine(tr3.durationTour);
            Console.WriteLine(tr4.priceTour);
            Console.WriteLine(trsp1.maxOfTourist);
            Console.WriteLine(tr1.priceTour);
            tr1.PriceOfGroupp(30);
            Console.WriteLine(tr1.PriceAlone());
            Console.WriteLine(trsp2.PriceOfGroupp(16));// -> return -1


            Console.ReadKey();


            //My GitHub https://github.com/Pribor86

        }
    }
}
