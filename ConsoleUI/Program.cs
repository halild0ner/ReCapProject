using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.DTOs;
using System;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Marka: {0} Renk:{1} Araba Adı:{2} Fiyatı:{3} Id:{4}",car.BrandName,car.ColorName,car.CarName,car.DailyPrice,car.Id);
            }

        }
    }
}
