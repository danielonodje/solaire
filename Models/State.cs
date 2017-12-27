using System.ComponentModel.DataAnnotations;
namespace solaire.Models{
    public class State {
	    [Key]
        public int Id { get; private set;}
        public string name;
    }
}