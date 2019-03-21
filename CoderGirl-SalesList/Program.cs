using System;
using System.IO;
using System.Collections.Generic;

namespace CoderGirl_SalesList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
            Console.ReadLine();
        }
        private void Run()
        {
            List<SalesRecord> salesRecordList = GetSalesRecordsFromFileData();
            int countNorthAmerica = GetCountForNorthAmerica(salesRecordList);
            Console.WriteLine(countNorthAmerica);
        }

        private int GetCountForNorthAmerica(List<SalesRecord> salesRecordList)
        {
            int count = 0;
            foreach (SalesRecord record in salesRecordList)
            {
                if(record.Region == "North America")
                {
                    count++;
                }
            }
            return count;
        }

        private List<SalesRecord> GetSalesRecordsFromFileData()
        {
            List<SalesRecord> salesRecordList = new List<SalesRecord>();
            bool isFirstRow = true;
            //@ symbol for literal string for file name
            foreach (string line in File.ReadLines(@"Data\1000 Sales Records.csv"))
            {
                if (isFirstRow)
                {
                    //continue skips the rest of this loop run, then proceeds through susequent loop runs
                    isFirstRow = false;
                    continue;
                }

                SalesRecord salesRecord = CreateSalesRecord(line);
                salesRecordList.Add(salesRecord);
            }
            return salesRecordList;
        }

        private SalesRecord CreateSalesRecord(string line)
        {
            SalesRecord salesRecord = new SalesRecord();
            string[] properties = line.Split(",");
            salesRecord.Region = properties[0];
            salesRecord.Country = properties[1];
            salesRecord.ItemType = properties[2];
            salesRecord.SaleChannel = properties[3];
            salesRecord.OrderPriority = properties[4];
            salesRecord.OrderDate = DateTime.Parse(properties[5]);

            return salesRecord;
        }
    }
}
