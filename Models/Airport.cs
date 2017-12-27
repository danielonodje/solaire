using System.ComponentModel.DataAnnotations;
namespace solaire.Models{
    public class Airport{
	    [Key]
        public int Id { get; private set;}
        public string Name;

        public string Code;

        public float Latitude;

        public float Longitude;

        public State State;
    }
}