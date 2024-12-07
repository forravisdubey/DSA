using System;
using System.Collections.Generic;
using System.Text;

namespace Algorigthms
{
    public class MostFrequentTrucks
    {
        public static List<string> GetMostFrequentTruck(List<string> trucks, int k)
        {
            List<string> mostFeq = new List<string>();
            Dictionary<string, int> truckArrivalFrequency = new Dictionary<string, int>();

            foreach(var truck in trucks)
            {
                if (truckArrivalFrequency.ContainsKey(truck))
                {
                    truckArrivalFrequency[truck]++;
                }
                else
                {
                    truckArrivalFrequency.Add(truck,1);
                }
            }

            return mostFeq;

        }
    }
}
