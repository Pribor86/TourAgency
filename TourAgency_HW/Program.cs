using System;

namespace TourAgency_HW
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Сортировка по названию тура

            //2.Распечатать отсортированную коллекцию

            //3.Поиск тура по названию тура

            //4.Найти среднюю цену тура
            TourList tourList = new TourList();
            Tour tr1 = new Tour("Saaremaa", 25, 100, 40);
            Tour tr2 = new Tour("Hiiumaa", 10, 100, 50);
            Tour tr3 = new Tour("Viljandi", 10, 100, 20);
            Tour tr4 = new Tour("Muhu", 10, 100, 30);
            Tour tr5 = new Tour("Parnu", 10, 100, 35);
            Tour tr6 = new Tour("SPB", 10, 100, 40);
            Tour tr7 = new Tour("Saaremaa", 30, 100, 50);//tr7 == tr1
            TourSpecial trsp1 = new TourSpecial("Paide", 15, 100, 5);// минимальное число для скидки стало 5
            TourSpecial trsp2 = new TourSpecial("Loitsu", 40, 100, 15);
            tourList.AddTour(trsp1);
            tourList.AddTour(trsp2);
            tourList.AddTour(tr1);
            tourList.AddTour(tr2);
            tourList.AddTour(tr3);
            tourList.AddTour(tr4);
            tourList.AddTour(tr5);
            tourList.AddTour(tr6);
            tourList.AddTour(tr7);// -> return false
            Console.WriteLine();
            Console.WriteLine("Average price: {0}", tourList.AveragePrice());
            Console.WriteLine();
            Console.WriteLine("**************************************");
            Console.WriteLine(tourList);
            Console.WriteLine("**************************************");
            
            Console.WriteLine(tr1.CheckTour(50));//-> false
            Console.WriteLine(tr1.PriceOfGroupp(10));
            Console.WriteLine(tr1.PriceAlone());
            Console.WriteLine(tr1.PriceOfGroupp(15));
            Console.WriteLine(tr1.SetPriceTour(10));
            Console.WriteLine(trsp1.PriceOfGroupp(100));//-> return -1
            Console.WriteLine(tr1.NameTour);
            Console.WriteLine(tr2.MaxOfTourist);
            Console.WriteLine(tr3.DurationTour);
            Console.WriteLine(tr4.PriceTour);
            Console.WriteLine(trsp1.MaxOfTourist);
            Console.WriteLine(tr1.PriceTour);
            tr1.PriceOfGroupp(30);
            Console.WriteLine(tr1.PriceAlone());
            Console.WriteLine(trsp2.PriceOfGroupp(16));// -> return -1



            
            Console.WriteLine(tourList.FindByName("Saaremaa"));
            tourList.SortList();
            Console.WriteLine();
            Console.WriteLine(tourList);
            Console.WriteLine();

            
            

            Console.ReadKey();


            


            //My GitHub https://github.com/Pribor86

        }
    }
}
