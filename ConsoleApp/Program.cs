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
                Room room = new Room();

                

                reservation.ArrivalDate = DateTime.Now.Date;
                reservation.DepartureDate = DateTime.Now.AddDays(1).Date;



            }

        }
    }
}
