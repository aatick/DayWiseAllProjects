using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorApp
{
    class Refrigerator
    {
        private double maxWeight = Double.MinValue;
        private double currentWeight; 

        public double CurrentWeight
        {
            get { return currentWeight; }
            private set { currentWeight = value; }
        }

        public double RemainingWeight
        {
            get { return MaxWeight - CurrentWeight; }
        }

        public double MaxWeight
        {
            get { return maxWeight; }
            set
            {
                if (value < 0)
                    throw new NegetiveMaxWeightException();
                if (maxWeight == Double.MinValue)
                    maxWeight = value;
                else
                    throw new ResetMaxWeightException();
            }
        }

        public void AddItems(int noOfItems, double weightPerItem)
        {
            double totalWeight = noOfItems*weightPerItem;
            if (MaxWeight > Double.MinValue)
            {
                if (MaxWeight - CurrentWeight >= totalWeight)
                    CurrentWeight += totalWeight;
                else
                    throw new OverflowToMaxWeightException();
            }
            else
                throw new MaxWeightNotSetException();
        }
    }
    public class OverflowToMaxWeightException : Exception
    {
        public OverflowToMaxWeightException()
            : base("Item's Weight exceeds maximum weight of the Refrigerator.")
        {
        }
    }
    public class ResetMaxWeightException : Exception
    {
        public ResetMaxWeightException()
            : base("Maximum Weight has been already set. You can not reset it.")
        {
        }
    }
    public class MaxWeightNotSetException : Exception
    {
        public MaxWeightNotSetException()
            : base("Maximum Weight has not set yet.")
        {
        }
    }
    public class NegetiveMaxWeightException : Exception
    {
        public NegetiveMaxWeightException()
            : base("Maximum Weight can not be Negetive.")
        {
        }
    }
    
}
