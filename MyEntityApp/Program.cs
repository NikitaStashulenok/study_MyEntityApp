using MyEntityApp.Controller;
using MyEntityApp.Model;
using System;
using System.Linq;

namespace MyEntityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                //create 2 Users
                var user1 = new User { Name = "Nikita", Age = 18 };
                var user2 = new User { Name = "Alice", Age = 17 };

                //add them to DataBase
                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
                Console.WriteLine("Save completed percfectly");

                //get objects from the DB and output to the console 
                var users = db.Users.ToList();
                Console.WriteLine("list of objects: ");
                foreach (var user in users)
                {
                    Console.WriteLine($"{user.Id}.{user.Name} -> {user.Age}");
                }
            }
            Console.ReadKey();
        }
    }
}
