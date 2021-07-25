namespace Sorbo_Assignment_7
{
    class Sales
    {
        private int invNum;
        private double saleAmt;
        public readonly double taxOwed;
        public const double bottomTax = .08; //for the bottom $100 of every transaction
        public const double topTax = .06;    //for anything over $100 of every transaction


        //get and set: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-properties

        public int InvNum
        {
            get
            {
             return   invNum;
            }
            set
            {
            invNum = value;
            }
        }

        public double SaleAmt
        {
            get
            { 
              return  saleAmt; 
            }
            set
            {
                saleAmt = value;
            }
        }

        public Sales(int InvNum, double SaleAmt)
        {
            this.invNum = InvNum;
            this.saleAmt = SaleAmt;

            taxOwed = Tax(SaleAmt);

        }

        public double Tax(double saleAmt)
        {
            double tax;
            
            if (saleAmt <= 100) tax = bottomTax * saleAmt;
            else tax = (bottomTax * 100) + (topTax * (saleAmt - 100));

            return tax;
        }
    }
}


    
