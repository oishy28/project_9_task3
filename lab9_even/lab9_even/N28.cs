using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_even
{
    public class N28
    {
       public  List<LectureRoom> lectureRoomslist = new List<LectureRoom>();
        
        public  List<Lab> labroomlist = new List<Lab>();
       


        public void showAllLabs()
        {
            foreach(Lab lab in labroomlist)
            {
                Console.WriteLine("Lab Room Name :   " + lab.getLabName() + "Capacity:  " + lab.getCapacity() );
            }

        }

        public void showAllLactureRoom()
        {
            foreach(LectureRoom Lectures in lectureRoomslist)
            {
                 Console.WriteLine("Lectrurer Room Name :    " + Lectures.getRoomName() + " Room Number :   "+ Lectures.getRoomNo()+" Capacity : " + Lectures.getcapacity());
            }
        }
        

    }
}
