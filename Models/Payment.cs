using System.ComponentModel.DataAnnotations;

namespace solaire.Models{
    public class Payment{
	    [Key]
        public int Id { get; private set;}
        public string ReferenceNumber;
    }
}