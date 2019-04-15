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
            var datesBefore = salesRecords.Any(tacoCat => tacoCat.OrderDate < cutoffDate);
            

            return datesBefore;
        }

        public List<string> GetCountries(List<SalesRecord> salesRecords)
        {
            List<string> countryResults = salesRecords.Select(tacoCat => tacoCat.Country).ToList();
            countryResults = countryResults.Distinct().ToList();
            return countryResults;
        }

        public int GetCountryCount(List<SalesRecord> salesRecords)
        {
            List<string> uniqueCountries = GetCountries(salesRecords);
            int countryCount = uniqueCountries.Count();
            return countryCount;
        }

        public decimal GetMaxProfit(List<SalesRecord> salesRecords)
        {
            decimal maxProfit = salesRecords.Max(tacoCat => tacoCat.TotalProfit);
            return maxProfit;
        }

        public decimal GetTotalRevenue(List<SalesRecord> salesRecords)
        {
            decimal totalRevenue = salesRecords.Sum(tacoCat => tacoCat.TotalRevenue);
            return totalRevenue;
        }

        public List<SalesRecord> OrderByShipDate(List<SalesRecord> salesRecords)
        {
            var orderedDates = salesRecords.OrderBy(p => p.ShipDate).ToList();
            return orderedDates;
                               
        }

        public List<SalesRecord> OrderByUnitsSoldDescending(List<SalesRecord> salesRecords)
        {
            var orderedUnits = salesRecords.OrderByDescending(tacoCat => tacoCat.UnitsSold).ToList();
            return orderedUnits;
        }
    }
}
