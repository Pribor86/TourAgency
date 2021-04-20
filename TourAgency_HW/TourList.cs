using System;
using System.Collections.Generic;
namespace TourAgency_HW
{
    class TourList
    {
        List<Tour> list;

        public TourList()
        {
            list = new List<Tour>();
        }

        public bool AddTour(Tour tour)
        {
            foreach (Tour tr in list)
            {
                if (tr.Equals(tour))
                {
                    return false;
                }
            }
            list.Add(tour);
            return true;

        }

        public override string ToString()
        {
            string tempString = "";
            int tempNumb = 1;
            foreach(Tour tr in list)
            {
                tempString += String.Format("Tour {0}.\n{1}\n\n", tempNumb, tr);
                tempNumb++;
            }
            return tempString;
        }
    }
}
