using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApplication.Models
{
    public class Restaurant
    {
        
        public int RestaurantRanking { get; set; }
        public string RestaurantName { get; set; }
        public string? FavoriteDish { get; set; } = "It's all Tasty!";
        public string RestaurantAddress { get; set; }
        public string? RestaurantPhone { get; set; }
        public string? WebsiteLink { get; set; } = "Coming Soon!";


        public static Restaurant[] GetRestaurants()
        {

            Restaurant r1 = new Restaurant
            {
                RestaurantRanking = 1,
                RestaurantName = "Texas Roadhouse",
                FavoriteDish = "Steak",
                RestaurantAddress = "123 University Ave.",
                RestaurantPhone = "801-555-3546",
                WebsiteLink = "www.texasroadhouse.com"

            };

            Restaurant r2 = new Restaurant
            {
                RestaurantRanking = 2,
                RestaurantName = "Blaze Pizza",
                FavoriteDish = "Pizza",
                RestaurantAddress = "1243 State Street",
                RestaurantPhone = "801-555-2866",
                WebsiteLink = "www.blazepizza.com"
            };

            Restaurant r3 = new Restaurant
            {
                RestaurantRanking = 3,
                RestaurantName = "Costa Vida",
                FavoriteDish = "Sweet Pork Salad",
                RestaurantAddress = "846 Cougar Boulevard",
                RestaurantPhone = "801-555-3328",
                WebsiteLink = "www.costavida.com"
            };

            Restaurant r4 = new Restaurant
            {
                RestaurantRanking = 4,
                RestaurantName = "Panda Express",
                FavoriteDish = "Shrimp",
                RestaurantAddress = "668 Cougar Boulevard",
                RestaurantPhone = "801-555-3478",
                WebsiteLink = "www.pandaexpress.com"
            };


            Restaurant r5 = new Restaurant
            {
                RestaurantRanking = 5,
                RestaurantName = "Wendy's",
                FavoriteDish = "4 for 4",
                RestaurantAddress = "354 Bulldog Boulevard",
                RestaurantPhone = "801-555-9978",
                WebsiteLink = "www.wendys.com"
            };




            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
