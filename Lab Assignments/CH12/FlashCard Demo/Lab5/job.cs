using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
  public class job
    {
        public double _TripFee;
        public string _Description;
        public double _HoursToComplete;
        public double _HourlyFee;
        public double _TotalFee;
        public job() { }
        public job(string description, double hoursToComplete,double hourlyFee,double TripFee)
        {
            _Description = description;
            _HoursToComplete = hoursToComplete;
            _HourlyFee = hourlyFee;
        }
        public float TripFee
        {
            set { _TripFee = 35; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public double HoursToComplete
        {
            set {  _HoursToComplete=value; }
            get { return _HoursToComplete; }

        }
        public float HourlyFee
        {
            get { return HourlyFee; }
            set { _HourlyFee = value; }
        }
        public double TotalFee
        {
            get { return _TotalFee; }
            set { _TotalFee = HourlyFee*HoursToComplete;}
        }
        public override string ToString()
        {
            return $"this job{Description} is {HourlyFee} and {TotalFee}";
        }

    }
}
