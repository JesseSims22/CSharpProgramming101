using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProgramming101
{
    class HomeServiceJobs
    {

        public string Name { get; set; }
        public double TimeInHours { get; set; }
        public  double Rate { get; set; }

        private double totalFeeForJob;

        public HomeServiceJobs(string name, double timeInHours, double rate)
        {
            this.Name = name;
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
            totalFeeForJob
        }
    }
}
