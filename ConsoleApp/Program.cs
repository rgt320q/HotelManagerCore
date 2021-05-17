using DataAccess.Concrete.EFCore;
using Entity.Concrete;
using System;

namespace ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            EfReservationDal efReservationDal = new EfReservationDal();


            DateTime dateTimeNow = DateTime.Now.Date;

            //using (var dataBase = new MainContext())
            //{
            //    dataBase.Database.EnsureCreated();

            //    var roomCount = dataBase.Rooms.ToList().Count;

            //    //dataBase.Rooms.Add(new Room { Name = "1023" ,PersonTotal=2,Price1=100,DoubleBed=1});

            //    //room1.Name = "3333";
            //    //room1.UpdateDateTime = DateTime.Now;

            //    //dataBase.Update(room1);

            //    var resultSave = dataBase.SaveChanges();

            //    Console.WriteLine("Result Save = " + resultSave);
            //    //Console.WriteLine("Now.Date = " + DateTime.Now);
            //    Console.WriteLine("Room count" + roomCount);


            //}



            Reservation reservation = new Reservation()
            {

                DepartureDate = dateTimeNow.AddDays(5),
                ArrivalDate = dateTimeNow,
                Adult = 2,
                Children = 1,
                AccommodationType = 1,
                Days = 0,
                GuestTotal = 1

            };
            Guest guest = new Guest()
            {
                Name = "Anakin",
                Surname = "Skywalker",
                Email = "anakin@jedi.com",
                Phone = "05319323396",
                Gender = 1,
                GuestNote = "He is very angry",
                IdentNumber = "11111111111"


            };

            Payment payment = new Payment()
            {
                TotalRoomPrice = 100,
                TotalKdv = 18,
                TotalPrice = 100,
                TotalAccommodationTax = 1
            };

            //List<Room> room = db.Rooms.ToList();

            //for (int i = 0; i < 1; i++)
            //{
            //    reservation.Rooms.Add(room[i]);
            //}

            reservation.Guests.Add(guest);

            reservation.Payment=payment;

            efReservationDal.Add(reservation);
            //var result = db.SaveChanges();

            Console.WriteLine("!!! !!! Added !!! !!!");

            //List<Reservation> reservationView = db.Reservations.ToList();
            //List<Reservation> reservations = efReservationDal.GetAll();

            //Console.WriteLine("Total Reservation = " + reservations.Count);



        }

        //using (var db = new MainContext())
        //{
        //    List<Reservation> reservation = db.Reservations.ToList();

        //    foreach (var item in reservation)
        //    {
        //        Console.WriteLine("Record + " + item);
        //    }

        //}

        //DateTime date1 = DateTime.Now.Date;
        //DateTime date2 = DateTime.Now.AddDays(5).Date;

        //int dayTotal = date2.Subtract(date1).Days;

        //Console.WriteLine("Total days = " + dayTotal);

    }
}

