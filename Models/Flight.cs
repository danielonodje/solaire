using System;

namespace solaire.Models{
    public class Flight{
        public int Id;
        public DateTime StartTime;
        public DateTime EndTime;
        public String Duration;

        public Airport StartLocation;

        public Airport EndLocation;
    }
}
