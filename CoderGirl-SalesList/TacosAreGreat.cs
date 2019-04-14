using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CoderGirl_SalesList
{
    public class TacosAreGreat : ISalesRecordAnalyzer
    {
        public bool AreOrderDatesBefore(DateTime cutoffDate, List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }

        public List<string> GetCountries(List<SalesRecord> salesRecords)
        {
            List<string> countryResults = salesRecords.Select(tacoCat => tacoCat.Country).ToList();
            countryResults = countryResults.Distinct().ToList();
            return countryResults;
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
