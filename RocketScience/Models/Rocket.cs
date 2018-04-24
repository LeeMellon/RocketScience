using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RocketScience.Models
{
    public class Rocket
    {
        public float Tonnage { get; set; }
        public float FinalSpeed { get; set; }
        public float RocketExhaust { get; set; }
        public float FuleLoad { get; set; }
        public string DestinationName { get; set; }

        public void SetDestination(string name, int speed)
        {
            this.FinalSpeed = speed;
            this.DestinationName = name;
        }

        public double GetFuel()
        {
            var FuelWeight = Math.Round((this.Tonnage * Math.Pow(2.718, (this.FinalSpeed / 3000))- this.Tonnage) * 1000);
            return FuelWeight;
        }
     
    }
    
    
}
