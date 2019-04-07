using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoderGirl_SalesList
{

    //Finish these methods using LINQ (select, where, any)
    //.Any will return true is anything is true
    
    class RandomClassName : ISalesRecordAnalyzer
    {
        public bool AreOrderDatesBefore(DateTime cutoffDate, List<SalesRecord> salesRecords)
        {
            return salesRecords.Any(record => record.OrderDate > cutoffDate);
        }

        public List<string> GetCountries(List<SalesRecord> salesRecords)
        {
            List<string> results = salesRecords.Select(record => record.Country).Distinct().ToList();
            return results;
        }

        public int GetCountryCount(List<SalesRecord> salesRecords)
        {
            return salesRecords.Select(record => record.Country).Distinct().Count();
        }

        public decimal GetMaxProfit(List<SalesRecord> salesRecords)
        {
            return salesRecords.Select(record => record.TotalProfit).Max();
        }

        public decimal GetTotalRevenue(List<SalesRecord> salesRecords)
        {
            return salesRecords.Select(record => record.TotalRevenue).Sum();
        }

        public List<SalesRecord> OrderByShipDate(List<SalesRecord> salesRecords)
        {
            return salesRecords.OrderBy(record => record.ShipDate).ToList();
        }

        public List<SalesRecord> OrderByUnitsSoldDescending(List<SalesRecord> salesRecords)
        {
            return salesRecords.OrderByDescending(record => record.UnitsSold).ToList();
        }
    }
}
