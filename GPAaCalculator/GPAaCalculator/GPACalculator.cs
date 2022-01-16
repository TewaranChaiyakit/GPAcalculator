using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPAaCalculator
{
    internal class GPACalculator
    {
        private double sum = 0;
        private int n = 0;
        private double max = 0;
        private double min = 4;
        private string maxname = string.Empty; // "  "
        private string alldata = string.Empty;
        private string minname = string.Empty; // "  "

        /// <summary>
        /// Add new GPA to class
        /// </summary>
        /// <param name="gpa">gpa score</param>
        public void addGPA(double gpa, string name)
        {
            this.sum += gpa;
            this .n++;
            this.alldata += name + " " + gpa + Environment.NewLine;

            if(this.max < gpa)
            {
                this.max = gpa;
                this.maxname = name;
                
            }
            if(this.min > gpa)
            {
                this.min = gpa;
                this.minname = name;
            }
            

            
                
        }
        /// <summary>
        /// Return GPAX of class
        /// </summary>
        /// <returns>GPAX</returns>
        public double getGPAX()
        {
            double result = this.sum / this.n;
            return result;
        }
        public double getMax() 
        {
            return this.max;
            
        }
        public string getMaxName() 
        {
            return maxname;
            
        }
        public string getAlldata()
        {
            return alldata;
        }
        public double getMin()
        {
            return min;
        }
        public string getMinName()
        {
            return minname;
        }






    }

}
