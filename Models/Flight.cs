using System;
using System.ComponentModel.DataAnnotations;

namespace solaire.Models{
    public class Flight{
	    [Key]
        public int Id { get; private set;}
        public DateTime StartTime;
        public DateTime EndTime;
        public string Duration;

        public Airport StartLocation;

        public Airport EndLocation;
    }
}
