using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_even
{
    public class Lab
    {
         private string labName;
        private int lab_capacity;

      
        public Lab()
        {

        }
        public string getLabName()
        {
            return this.labName;
        }
        public void setLabName(string value)
        {
            this.labName = value;
        }

        public int getCapacity()
        {
            if (lab_capacity < 0) { lab_capacity = 0; }
            return this.lab_capacity;
        }
        public void setCapacity(int value)
        {
            this.lab_capacity = value;
        }
    }
   
   
}
