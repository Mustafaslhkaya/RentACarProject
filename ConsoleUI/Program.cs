﻿using Business.Concrete;
using System;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestCars();
            BrandManager bm = new BrandManager(new EfBrandDal());
            var result = bm.GetBrand(2);
            Console.WriteLine(result.Name);

        }

        private static void TestCars()
        {
            CarManager cm = new CarManager(new EfCarDal());
            cm.Add(new Car { Name = "Maseratti", BrandId = 2, ColorId = 3, DailyPrice = 300000, Description = "dsada", ModelYear = DateTime.Now });


            foreach (var cars in cm.GetCarDetails())
            {
                Console.WriteLine(cars.CarName + "/ " + cars.BrandName + "/ ");
            }
        }
    }
}
