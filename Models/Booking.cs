using System.ComponentModel.DataAnnotations;

namespace solaire.Models{
    public class Booking{
        [Key]
        public int Id { get; private set;}
        public User User;
        public Payment Payment;
    }
}