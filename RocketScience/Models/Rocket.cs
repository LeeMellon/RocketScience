using GeoCoordinatePortable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RocketScience.Models
{
    public class Rocket
    {
        public string Name { get; set; }
        public float Tonnage { get; set; }
        public float FinalSpeed { get; set; }
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

        public double GetCrew(double days, double tasks)
        {
            var RequiredCrew = Math.Ceiling(((tasks / days) / 64));
            return RequiredCrew;
        }

        public double GetDistance(double latA, double longA, double latB, double longB)
        {
            var StartPoint = new GeoCoordinate(latA, longA);
            var EndPoint = new GeoCoordinate(latB, longB);
            var DistanceKLM =  StartPoint.GetDistanceTo(EndPoint)/1000;
            var DistanceKM = Math.Round(DistanceKLM * .5399568);
            return DistanceKM;
        }
     
    }
    
    
}
