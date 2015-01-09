using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class Employee
    {
        private string employeeName;
        private float basicSalary;
        private float houseRentPercentage;
        private float medicalAllowancePercentage;

        public Employee(string name, float basicSalaryAmount, float percentageOfHouseRent, float percentageOfMedicalAllowance)
        {
            employeeName = name;
            basicSalary = basicSalaryAmount;
            houseRentPercentage = percentageOfHouseRent;
            medicalAllowancePercentage = percentageOfMedicalAllowance;
        }
        private float calculateHouseRent()
        {
            float houseRent = (basicSalary*houseRentPercentage)/100;
            return houseRent;
        }
        private float calculateMedicalAllowance()
        {
            float medicalAllowance = (basicSalary * medicalAllowancePercentage) / 100;
            return medicalAllowance;
        }

        public float CalculateTotalSalary()
        {
            return basicSalary + calculateHouseRent() + calculateMedicalAllowance();
        }
    }
}
