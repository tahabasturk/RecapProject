using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();
            inMemoryCarDal.Add(new Car { Id = 6, BrandId = 2, ColorId = 2, DailyPrice = 20000, ModelYear = 1985, Description = "Pembe Araba" });
            inMemoryCarDal.Update(new Car { Id = 6, BrandId = 2, ColorId = 2, DailyPrice = 60000, ModelYear = 1975, Description = "Lacivert Araba" });
            inMemoryCarDal.Delete(new Car { Id = 6 });

            Console.ReadLine();
        }
    }
}
