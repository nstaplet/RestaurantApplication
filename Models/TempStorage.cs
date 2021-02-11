using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApplication.Models
{
    public static class TempStorage
    {
        private static List<Restaurant> applications = new List<Restaurant>();

        public static IEnumerable<Restaurant> Applications => applications;

        public static void AddApplication(Restaurant application)
        {
            applications.Add(application);
        }
    }
}
