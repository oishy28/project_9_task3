using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_even
{
    public  class LectureRoom
    {
        private string roomName;
        private int roomNo;
        private int capacity;
         
        public LectureRoom()
        {

        }

        
        public string getRoomName()
        {
            return this.roomName;
        }

        public int getRoomNo()
        {
            if (roomNo < 0) { roomNo=0; }
            return this.roomNo;
        }
        public int getcapacity()
        {
            
            return this.capacity;
        }

        public void setRoomName(string value)
        {
            this.roomName = value;
        }

        public void setRoomNo(int value)
        {
            this.roomNo = value;
        }

        public void setcapacity(int value)
        {
            this.capacity = value;
        }

    }

    
}
