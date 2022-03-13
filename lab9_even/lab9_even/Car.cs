using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_even
{
    public class Car
    {
        private int seats;
        private int wheels;
        private int doors;
        private int maximum_acceleration;
        private int fuel_capacity;

        public int Seats
        {
            get { return seats; }  
            set { seats = value; }
        }
        public int Wheels
        {
            get { return wheels; }
            set { wheels = value; }
        }
        public int Doors
        {
            get { return doors; }
            set { doors = value; }
        }
        public int MaximumAcceleration
        {
            get { return maximum_acceleration; }
            set { maximum_acceleration = value; }
        }
        public int FuelCapacity
        {
            get { return fuel_capacity; }
            set { fuel_capacity = value; }
        }

        
        

    }
}
