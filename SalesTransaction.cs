using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorbo_Assignment_7
{
    class SalesTransaction
    {
        public string salesRep;
        public double salesAmt;
        public double commissionValue;
        public double commissionRate=.20;
       
        
    
        public SalesTransaction (string salesRep, double salesAmt, double commissionsRate)
        {
            this.salesRep = salesRep;
            this.salesAmt = salesAmt;
            this.commissionValue = commissionRate*salesAmt;

            
        }

        public SalesTransaction(string salesRep, double salesAmt)
        {
            this.salesRep = salesRep;
            this.salesAmt = salesAmt;
            this.commissionRate = 0;
            this.commissionValue = 0;

            
        }

        public SalesTransaction(string salesRep)
        {
            this.salesRep = salesRep;
            this.salesAmt = 0;
            this.commissionRate = 0;
            this.commissionValue = 0;
         
         
        }

      

        public static double SalesTotal(double Total)
        {
            Console.WriteLine();
            return Total;
        }

    }

    
}
