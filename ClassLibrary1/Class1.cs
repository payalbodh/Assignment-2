using System;

namespace ClassLibrary1
{
    public class Employee
    {
        private int EmpNo;
        private string EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;
        public int empno
        {
            get;
            set;
        }
        public string empname
        {
            get;
            set;
        }
        public double salary
        {
            get;
            set;
        }
        public double hra
        {
            get;
            set;
        }

        public double ta
        {
            get;
            set;
        }

        public double da
        {
            get;
            set;
        }

        public double pf
        {
            get;
            set;
        }
        public double netsalary
        {
            get;
            set;
        }
        public double grosssalary
        {
            get;
            set;
        }

        public double computeGrossSalary(int EmpNo,string EmpName,double salary)
        {
            
            if (salary < 5000)
            {
               hra= 0.1 * salary;
                ta = 0.05 * salary;
                da = 0.15 * salary;
                GrossSalary = salary + hra + ta + da;
                
            }
            else if(salary < 10000)
            {
                hra = 0.15 * salary;
                ta = 0.1 * salary;
                da = 0.2 * salary;

                GrossSalary = salary + hra + ta + da;
            }
            else if (salary < 15000)
            {
                hra = 0.2 * salary;
                ta = 0.15 * salary;
                da = 0.25 * salary;

                GrossSalary = salary + hra + ta + da;
            }
            else if (salary < 20000)
            {
                hra = 0.25 * salary;
                ta = 0.20 * salary;
                da = 0.30 * salary;

                GrossSalary = salary + hra + ta + da;
            }
            else if (salary >= 20000)
            {
                hra = 0.30 * salary;
                ta = 0.25 * salary;
                da = 0.35 * salary;

                GrossSalary = salary + hra + ta + da;
            }
            return GrossSalary;
        }
        public void CalculateSalary()
        {
            double grosssalary = computeGrossSalary(1, "Payal", 20000);
            PF = 0.1 * grosssalary;
            TDS = 0.18 * grosssalary;
            NetSalary = GrossSalary - (PF + TDS);
            Console.WriteLine("NetSalary of Employee is {0}", NetSalary);
        }

    }
}
