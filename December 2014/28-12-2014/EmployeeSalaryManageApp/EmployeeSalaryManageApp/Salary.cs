using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryManageApp
{
    class Salary
    {
        private double medicalPercentage;
        private double conveyancePercentage;
        public double Basic { get; private set; }

        public double MedicalAllowance
        {
            get { return (Basic*medicalPercentage)/100; }
        }

        public double ConveyanceAllowance
        {
            get { return (Basic*conveyancePercentage)/100; }
        }
        public int NumberOfIncrements { get; private set; }

        public Salary(double basicSalary, double percentageOfMedicalAllowance, double percentageOfConveyanceAllowance)
        {
            Basic = basicSalary;
            medicalPercentage = percentageOfMedicalAllowance;
            conveyancePercentage = percentageOfConveyanceAllowance;
        }
        public double TotalSalary
        {
            get { return Basic + MedicalAllowance + ConveyanceAllowance; }
        }
        public void Increase(double increasePercentage)
        {
            NumberOfIncrements++;
            Basic += (Basic*increasePercentage)/100;
        }

    }
}
