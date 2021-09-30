using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class employee
    {
        public int empid;
        public string name;
        double basesalary;
        double HRA;
        double travelallo;




        public employee(int EmpID,string Empname,double Basesalary,double houseallounce,double travel_allounce)
        {
            this.empid = EmpID;
            this.name = Empname;
            this.basesalary = Basesalary;
            this.HRA = houseallounce;
            this.travelallo = travel_allounce;

        }
        public double getsalary()
        {
            return basesalary;
        }
        public double getHRA()
        {
            return HRA;
        }
        public double gettravel()
        {
            return travelallo;
        }
        public double gettax()
        {
            double netsalary = basesalary + HRA + travelallo;
            double tax = 0;

            if (netsalary < 600000)
            {
                tax = 0;
            }
            else if(netsalary>= 600000 && netsalary<=100000)
            {
                tax = (netsalary - 600000) * 0.10;
            }
            else
            {
                tax = (netsalary - 100000) * 0.20;
            }
            return tax;

        }
    }
    class outputofemployee
    {
        public static void Main()
        {
            Console.WriteLine("enter employee id");
            int EmpID = int.Parse(Console.ReadLine());

            Console.WriteLine("enter employee name");
            string Empname = (Console.ReadLine());

            Console.WriteLine("enter employee house allounce");
            double houseallounce = double.Parse(Console.ReadLine());


            Console.WriteLine("enter employee salary");
            double Basesalary = double.Parse(Console.ReadLine());


            Console.WriteLine("enter employee travel allounce");
            double travel_allounce = double.Parse(Console.ReadLine());



            employee e = new employee(EmpID,Empname, Basesalary, houseallounce, travel_allounce);

            Console.WriteLine(" tax = " + e.gettax());



        }
    }


}
