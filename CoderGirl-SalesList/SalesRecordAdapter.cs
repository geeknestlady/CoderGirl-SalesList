﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CoderGirl_SalesList
{
    public class SalesRecordAdapter : ISalesRecordAdapter
    {
        public List<SalesRecord> GetSalesRecordsFromCsvFile(string filePath)
        {
            List<SalesRecord> salesRecords = new List<SalesRecord>();
            bool isFirstRow = true;
            foreach (string line in File.ReadLines(filePath))
            {
                if (isFirstRow)
                {
                    isFirstRow = false;
                    continue;
                }

                SalesRecord salesRecord = CreateSalesRecord(line);
                salesRecords.Add(salesRecord);
            }
            return salesRecords;
        }

        private SalesRecord CreateSalesRecord(string line)
        {
            SalesRecord salesRecord = new SalesRecord();
            string[] properties = line.Split(",");
            salesRecord.Region = properties[0];
            salesRecord.Country = properties[1];
            salesRecord.ItemType = properties[2];
            salesRecord.SalesChannel = properties[3];
            salesRecord.OrderPriority = properties[4];
            salesRecord.OrderDate = DateTime.Parse(properties[5]);
            salesRecord.OrderID = int.Parse(properties[6]);
            salesRecord.ShipDate = DateTime.Parse(properties[7]);
            salesRecord.UnitsSold = int.Parse(properties[8]);
            salesRecord.UnitPrice = decimal.Parse(properties[9]);
            salesRecord.UnitCost = decimal.Parse(properties[10]);
            salesRecord.TotalRevenue = decimal.Parse(properties[11]);
            salesRecord.TotalCost = decimal.Parse(properties[12]);
            salesRecord.TotalProfit = decimal.Parse(properties[13]);
           

            return salesRecord;
        }
    }
}
