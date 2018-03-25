using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Car
    {
        public Car(string brand, int maxSpeed, DateTime date, string type)
        {
            Brand = brand;
            MaxSpeed = maxSpeed;
            ProductionDate = date;
            Type = type;
        }
        public string Brand
        {
            get;
            set;
        }
        public int MaxSpeed
        {
            get;
            set;
        }
        public DateTime ProductionDate
        {
            get;
            set;
        }
        public string Type
        {
            get;
            set;
        }
    }
}
