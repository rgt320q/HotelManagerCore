using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EFCore
{
    public class MainContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=HotelManagerCore;Trusted_Connection=true");
        }

        public DbSet<BaseConfiguration> baseConfigurations { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }


        //public DbSet<Address> Addresses { get; set; }
        //public DbSet<City> Cities { get; set; }
        //public DbSet<District> Districts { get; set; }
        //public DbSet<PaymentType> PaymentTypes { get; set; }
        //public DbSet<ReservationStatus> ReservationStatuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Room Samples
            modelBuilder.Entity<Room>()
                .HasData(
                new Room { Id = 1, Name = "102", SingleBed = 2, PersonTotal = 2, Price1 = 100 },
                new Room { Id = 2, Name = "103", DoubleBed = 1, PersonTotal = 2, Price1 = 100 },
                new Room { Id = 3, Name = "104", DoubleBed = 1, PersonTotal = 2, Price1 = 100 },
                new Room { Id = 4, Name = "105", SingleBed = 1, PersonTotal = 1, Price1 = 80 },
                new Room { Id = 5, Name = "106", DoubleBed = 1, PersonTotal = 2, Price1 = 100 },
                new Room { Id = 6, Name = "107", DoubleBed = 1, PersonTotal = 2, Price1 = 100 },
                new Room { Id = 7, Name = "108", DoubleBed = 1, PersonTotal = 2, Price1 = 100 },
                new Room { Id = 8, Name = "109", DoubleBed = 1, PersonTotal = 2, Price1 = 100 },
                new Room { Id = 9, Name = "110", DoubleBed = 1, PersonTotal = 2, Price1 = 100 },
                new Room { Id = 10, Name = "101", DoubleBed = 1, PersonTotal = 2, Price1 = 100 }
                );

            modelBuilder.Entity<BaseConfiguration>()
                .HasData(
                new BaseConfiguration
                {
                    AccommodationFee = 100,
                    Active = true,
                    BreakfastPrice = 30,
                    CompanyName = "Hotel Manager Core",
                    DailyAdultFee = 110,
                    DailyChildFee = 60,
                    DailyGuestFeeForRoom = 0,
                    DinnerPrice = 50,
                    LunchPrice = 35,
                    TaxRateForAccommodation = 1,
                    TaxRateForKDV = 18,

                }
                );            

        }


    }

}

