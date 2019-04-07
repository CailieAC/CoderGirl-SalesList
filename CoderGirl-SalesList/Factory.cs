using System;
using System.Collections.Generic;
using System.Text;

namespace CoderGirl_SalesList
{
    public class Factory
    {
        //usually would have one factory per interface, but we have two here
        public ISalesRecordAdapter SalesRecordAdapter { get; private set; }
        public ISalesRecordAnalyzer SalesRecordAnalyzer { get; private set; }

        public Factory()
        {
            //TODO: Add specific implementation classes
            this.SalesRecordAnalyzer = new RandomClassName();
            this.SalesRecordAdapter = new SalesRecordAdapter();


        }
    }
}
