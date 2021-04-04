﻿using System;

namespace TourAgency_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            TourList tour = new TourList();
            Tour tr1 = new Tour("Saaremaa", 10, 150, 40);
            Tour tr2 = new Tour("Hiiumaa", 10, 10, 50);
            Tour tr3 = new Tour("Viljandi", 10, 150, 20);
            Tour tr4 = new Tour("Muhu", 10, 150, 30);
            Tour tr5 = new Tour("Parnu", 10, 150, 35);
            Tour tr6 = new Tour("SPB", 10, 150, 40);

            tour.AddTour(tr1);
            tour.AddTour(tr2);
            tour.AddTour(tr3);
            tour.AddTour(tr4);
            tour.AddTour(tr5);
            tour.AddTour(tr6);
            Console.WriteLine("**************************************");
            Console.WriteLine(tour);
            Console.WriteLine("**************************************");

            Console.WriteLine(tr1.CheckTour(30));
            tr1.PriceOfGroupp(50);
            Console.WriteLine(tr1.TourType());
            Console.WriteLine(tr1.PriceAlone());
        }
    }
}