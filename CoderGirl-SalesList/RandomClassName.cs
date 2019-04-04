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
            //Just an example for Any, but NOT correct for this method!!
            //decimal[] profits = { 1.3m, 3.44m, 4.9m };
            //bool result = salesRecords.Any(record => profits.Contains(record.TotalProfit)).ToList();

            return salesRecords.Any(record => record.OrderDate > cutoffDate);
        }

        public List<string> GetCountries(List<SalesRecord> salesRecords)
        {
            List<string> results = salesRecords.Select(record => record.Country).Distinct().ToList();
            return results;
        }

        public int GetCountryCount(List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }

        public decimal GetMaxProfit(List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }

        public decimal GetTotalRevenue(List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }

        public List<SalesRecord> OrderByShipDate(List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }

        public List<SalesRecord> OrderByUnitsSoldDescending(List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }
    }
}
