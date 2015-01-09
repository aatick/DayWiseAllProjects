using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {
        private string name;
        private string regNo;
        private double minSpeed;
        private double maxSpeed;
        private double averageSpeed;
        private int speedCounter;

        public Vehicle(string vehicleName,string regNo)
        {
            name = vehicleName;
            this.regNo = regNo;
            speedCounter = -1;
        }

        public string Name
        {
            get { return name; }
        }

        public string RegNo
        {
            get { return regNo; }
        }

        public double Speed
        {
            set
            {
                SetMinSpeed(value);
                SetMaxSpeed(value);
                SetAverageSpeed(value);
            }
        }

        public double MinSpeed
        {
            get { return minSpeed; }
        }

        public double MaxSpeed
        {
            get { return maxSpeed; }
        }

        public double AverageSpeed
        {
            get { return averageSpeed; }
        }


        private void SetMinSpeed(double currentSpeed)
        {
            minSpeed = speedCounter == -1 ? currentSpeed : Math.Min(MinSpeed, currentSpeed);
        }

        private void SetMaxSpeed(double currentSpeed)
        {
            maxSpeed = Math.Max(MaxSpeed, currentSpeed);
        }

        private void SetAverageSpeed(double currentSpeed)
        {
            speedCounter++;
            averageSpeed = speedCounter == 0? currentSpeed: (averageSpeed*speedCounter + currentSpeed)/(speedCounter + 1);
        }
    }
}
