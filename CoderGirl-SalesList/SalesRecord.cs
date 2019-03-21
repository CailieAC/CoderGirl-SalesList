using System;
using System.Collections.Generic;
using System.Text;

namespace CoderGirl_SalesList
{
    //each line of the data file will be an instance of this class (only first six items)
    public class SalesRecord
    {
        //Region,Country,Item Type,Sales Channel,Order Priority,Order Date
        public string Region { get; set; }
        public string Country { get; set; }
        public string ItemType { get; set; }
        public string SaleChannel { get; set; }
        public string OrderPriority { get; set; }
        public DateTime OrderDate { get; set; }


    }
}
