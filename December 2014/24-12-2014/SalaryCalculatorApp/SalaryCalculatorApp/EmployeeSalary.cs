using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class EmployeeSalary
    {
        private string employeeName;
        private double basicOfSalary;
        private double houseRentPercentage;
        private double medicalAllowancePercentage;

        public string Name
        {
            get { return employeeName; }
        }
        public EmployeeSalary(string name, double basicOfSalaryAmount, double percentageOfHouseRent, double percentageOfMedicalAllowance)
        {
            employeeName = name;
            basicOfSalary = basicOfSalaryAmount;
            houseRentPercentage = percentageOfHouseRent;
            medicalAllowancePercentage = percentageOfMedicalAllowance;
        }
        private double CalculateHouseRent()
        {
            return (basicOfSalary*houseRentPercentage)/100;
        }
        private double CalculateMedicalAllowance()
        {
            return (basicOfSalary * medicalAllowancePercentage) / 100;
        }

        public double CalculateTotalSalary()
        {
            return basicOfSalary + CalculateHouseRent() + CalculateMedicalAllowance();
        }
    }
}
