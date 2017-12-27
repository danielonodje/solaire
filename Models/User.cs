using System.ComponentModel.DataAnnotations;
namespace solaire.Models{
    public class User {
	    [Key]
        public int Id { get; private set;}
        public string Title;
        public string Name;
        public string Phonenumber;
        public string Email;
    }
}