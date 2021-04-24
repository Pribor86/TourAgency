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

        public string FindByName(string name)
        {
            string result = "";
            foreach (Tour tr in list)
            {
                if (tr.NameTour == name)
                {
                    result += tr.ToString() + "\n";
                }
            }
            return result;
        }
        public void SortList()
        {
            list.Sort();
        }

        public double AveragePrice()
        {
            double summ = 0;
            foreach (Tour tr in list)
            {
                summ += tr.PriceTour;
            }
            double averg = summ / list.Count;
            return averg;
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
