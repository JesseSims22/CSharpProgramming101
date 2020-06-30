using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProgramming101
{
    class HomeServiceJobs
    {

        public string Name { get; set; }


        private double timeInHours;
        private double rate;
        private double totalFeeForJob;

        public HomeServiceJobs(string name, double timeInHours, double rate)
        {
            Name = name;
            TimeInHours = timeInHours;
            Rate = rate;
        }

        public double TotalFee
        {

            get
            {
                return totalFeeForJob;
            }
            
        }

        private void calcTotalFee()
        {
            totalFeeForJob = timeInHours * rate;
        }

        public double TimeInHours 
        { 
            get
            {
                return timeInHours;
            }
            set
            {
                timeInHours = value;
                calcTotalFee();
            }
         }

        public double Rate 
        {
            get
            {
                return rate;
            }

            set
            {
                rate = value;
                calcTotalFee();
            }
           
        }
    }
}
