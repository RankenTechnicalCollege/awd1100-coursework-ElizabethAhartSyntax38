using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    public class Conference
    {
        string _groupName;
        DateTime _startDate;
        int _attendees = 0;
        public ROOMS _rooms;
        
        public string Display()
        {
            int attendees = Attendees;
            DateTime date = StartDate;
            string groupName = GroupName;
            ROOMS room = Room;
            return$"{groupName} {room} {date.ToShortDateString()}  {attendees}\n";
        }
      
        public int Attendees {  get { return _attendees; } set { _attendees = value; }}
        public ROOMS Room { get { return _rooms; } set { _rooms = value; }}
        public string GroupName { get { return _groupName; } set {_groupName = value; }}
        public DateTime StartDate { get { return _startDate; } set { _startDate = value; }}
        
           
            

    }
}
