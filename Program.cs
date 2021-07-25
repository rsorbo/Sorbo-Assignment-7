using System;

namespace Sorbo_Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;

            do
            {
                result = DisplayMenu();
                Run(result);
            }
            while (result.ToUpper() != "E");

            Console.WriteLine(" Good Bye...");

        }
        public static string DisplayMenu()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Rob Sorbo");
            Console.WriteLine("Homework 7");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1.");
            Console.WriteLine("Hit [2] to run Exercise 2.");
            Console.WriteLine("Hit [3] to run Exercise 3.");
            Console.WriteLine("Hit [4] to run Exercise 4.");
            Console.WriteLine("Hit [5] to run Exercise 5.");

            Console.WriteLine();
            Console.WriteLine("Hit [E]: Exit;");
            Console.WriteLine();
            Console.WriteLine();

            var result = Console.ReadLine();
            return result;


        }
        private static bool Run(string exeArg)

        {
            switch (exeArg.ToLower())
            {

                case "1":
                    DoExe1();
                    return true;

                case "2":
                    DoExe2();
                    return true;

                case "3":
                    DoExe3();
                    return true;

                case "4":
                    DoExe4();
                    return true;

                case "5":
                    DoExe5();
                    return true;

                default:
                    Console.WriteLine("Exiting the Program!");
                    return true;
            }
        }
        private static void DoExe1()
        {
            SalesTransaction s1 = new SalesTransaction("Abbott", 2000, .2);
            SalesTransaction s2 = new SalesTransaction("Bender", 4000);
            SalesTransaction s3 = new SalesTransaction("Carter");
           //SalesTransaction total = s1+s2+s3

            Display(s1);
            Display(s2);
            Display(s3);
            DisplayTotal(s1, s2, s3); //this works but isn't the scope of the assignment ... Need to figure out the + Operator
            
        }

        private static void Display(SalesTransaction salesTransaction)
        {
            string Rep = salesTransaction.salesRep;
            double Amt = salesTransaction.salesAmt;
            double ComRate = salesTransaction.commissionRate;
            double ComVal = salesTransaction.commissionValue;

            Console.WriteLine($"{Rep} had sales totaling {Amt.ToString("C")}. Commission rate is {ComRate}; commission value is {ComVal}");
        }

        private static void DisplayTotal(SalesTransaction salesTransaction, SalesTransaction salesTransaction1, SalesTransaction salesTransaction2)
        {
            double Total= salesTransaction.salesAmt;
            Total += salesTransaction1.salesAmt;
            Total += salesTransaction2.salesAmt;
            Console.WriteLine($"Total sales: {Total.ToString("C")}");
            
        }

        private static void DoExe2()
        {
            Room[] rooms = new Room[8];
            int x;
            int len = 8;
            int wid = 8;
            int high = 8;

            for (x=0; x<rooms.Length; ++x)
            {
                rooms[x] = new Room(len, wid, high);
                len += 2;
                wid += 1;
                if (x%2==1)
                { 
                    high += 1; 
                }
            }

            for (x=0; x<rooms.Length; ++x)
            {
                Console.WriteLine("For a {0} X {1} X {2} foot room", rooms[x].len, rooms[x].wid, rooms[x].high);
                Console.WriteLine("\tTwo walls are {0} long and {1} high", rooms[x].len, rooms[x].high);
                Console.WriteLine("\t   and the other two walls are {0} long and {1} high", rooms[x].wid, rooms[x].high);
                Console.WriteLine("\tTotal wall area is {0}, so you need {1} gallon(s) of paint", rooms[x].area, rooms[x].gal);
                Console.WriteLine();
            }
        }
        private static void DoExe3()
        {
            Sales[] sale = new Sales[10];
            int invNum;
            double saleAmt;
            int x;

            for (x=0; x<sale.Length; ++x)
            {
                Console.Write("Enter inventory #{0} >> ", x+1);
                invNum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter amount of sale >> ");
                saleAmt = Convert.ToDouble(Console.ReadLine());
                

                sale[x] = new Sales(invNum, saleAmt);
            }
           
            Console.WriteLine();

            for (x=0; x<sale.Length; ++x)
            {
                Console.WriteLine("Sale #{0}, for Inventory #{1}, the Amount is {2}", x+1, sale[x].InvNum, sale[x].SaleAmt.ToString("C"));
                Console.WriteLine("\tTax is {0}", sale[x].taxOwed.ToString("C"));
            }
          

        }
        private static void DoExe4()
        {
            Car myCar = new Car(32000, "red");
            Car yourCar = new Car(14000);
            Car theirCar=new Car();

            Console.WriteLine("My {0} car cost {1}", myCar.Color, myCar.Price.ToString("C"));
            Console.WriteLine("Your {0} car cost {1}", yourCar.Color, yourCar.Price.ToString("C"));
            Console.WriteLine("Their {0} car cost {1}", theirCar.Color, theirCar.Price.ToString("C"));

        }
        private static void DoExe5()
        {
            const int STARTINGNUM = 201601;
            BoatLicense[] license = new BoatLicense[3];
            string LicNum="";
            string LicSt="";
            int MotSize=0;
            double LicFee=0;
            
            
            int x;
            for (x = 0; x < license.Length; ++x)
            {
                LicNum = (x + "" + STARTINGNUM);

                if (x == 0) 
                {
                    LicSt = "WI";
                    MotSize = 30;
                    LicFee = 25;
                }
                if (x==1)
                {
                    LicSt = "MI";
                    MotSize = 50;
                    LicFee = 25;
                }
                if (x==2)
                {
                    LicSt = "MN";
                    MotSize = 100;
                    LicFee = 38;
                }
                

                license[x] = new BoatLicense(LicNum, LicSt, MotSize, LicFee) ;
                DisplayLic(license[x]);
            }

      
         }

        public static void DisplayLic(BoatLicense boatLicense)
        {
            Console.WriteLine("Boat #{0} from {1} has a {2} HP motor", boatLicense.LicenseNum, boatLicense.State, boatLicense.MotorSizeInHP);
            Console.WriteLine("\tThe price for the license is {0}", boatLicense.LicFee.ToString("C"));
            Console.WriteLine();
        }

    }
}