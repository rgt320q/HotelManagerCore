using DataAccess.Concrete.EFCore;
using Entity.Concrete;
using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {


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

            using (var db = new MainContext())
            {

                Reservation reservation = new Reservation();
                Guest guest = db.Guests.FirstOrDefault(g => g.Id == 5);
                Room room = db.Rooms.FirstOrDefault(r => r.Id == 2);
                Payment payment = db.Payments.FirstOrDefault(p => p.Id == 1);


                reservation.ArrivalDate = DateTime.Now.Date;
                reservation.DepartureDate = DateTime.Now.AddDays(3).Date;
                reservation.Adult = 2;
                reservation.Children = 2;
                //reservation.GuestTotal = 100;
                reservation.Days = 100;
                reservation.AccommodationType = 1;

                reservation.Guests.Add(guest);
                reservation.Rooms.Add(room);
                Payment pay1 = new Payment() { TotalPrice = 100 };
                reservation.Payments.Add(payment);
                reservation.Payments.Add(pay1);

                db.Add(reservation);
                var result = db.SaveChanges();

                Console.WriteLine("Total result = " + result);

            }

            //DateTime date1 = DateTime.Now.Date;
            //DateTime date2 = DateTime.Now.AddDays(5).Date;

            //int dayTotal = date2.Subtract(date1).Days;

            //Console.WriteLine("Total days = " + dayTotal);

        }
    }
}
