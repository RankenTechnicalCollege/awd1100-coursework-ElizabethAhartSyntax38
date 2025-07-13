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
        
        public string Display()
        {
            return$"{_groupName} {_startDate} {Room} {_attendees}";
        }
        public Conference()
        {
            _groupName = _groupName;
            _startDate = new DateTime(int.MinValue);
            
            int _attendees = 0;
           string[] Room = new string[20];

        }
        public int Attendees {  get { return _attendees; } set { _attendees = value; }}
        public string[] Room { get { return Room; } set { Room = value; }}
        public string GroupName { get { return _groupName; } set {_groupName = value; }}
        public DateTime StartDate { get { return _startDate; } set { _startDate = value; }}
        
           
            

    }
}
