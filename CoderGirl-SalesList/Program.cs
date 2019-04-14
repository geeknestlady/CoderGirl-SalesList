using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace CoderGirl_SalesList
{
    public class Program
    {
        private string filePath = @"1000 Sales Records.csv";
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
            Console.ReadLine();
        }

        private void Run()
        {
            //List<SalesRecord> salesRecords = GetSalesRecordsFromFileData();
            //int countNorthAmerica = GetCountForNorthAmerica(salesRecords);
            //Console.WriteLine(countNorthAmerica);
        }

        private int GetCountForNorthAmerica(List<SalesRecord> salesRecords)
        {
            int count = 0;
            foreach(SalesRecord record in salesRecords)
            {
                if(record.Region == "North America")
                {
                    count++;
                }
            }

            return count;
        }



   
    }
}