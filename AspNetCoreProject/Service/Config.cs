using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreProject.Service
{
    public class Config
    {
        public static string ConnectionString { get; set; } = "Data Source=(localdb)\\MSSQLLocalDB; Database=AspProject; "; //Persist Security Info=false; User ID='id'; Password='password
        public static string CompanyName { get; set; } = "HappyDelivery";
        public static string CompanyPhone { get; set; } = "+380(98)-123-21-12";
        public static string CompanyEmail { get; set; } = "happydelivery@gmail.com";

    }
}
