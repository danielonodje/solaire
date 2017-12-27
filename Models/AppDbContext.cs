using Microsoft.EntityFrameworkCore;

namespace solaire.Models{
    public class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<Airport> Airports {get; set;}
        public DbSet<Booking> Bookings {get; set;}
        public DbSet<Flight> Flights {get; set;}
        public DbSet<Payment> Payments {get; set;}
        public DbSet<State> States {get; set;}
        public DbSet<User> Users {get; set;}
    } 
}