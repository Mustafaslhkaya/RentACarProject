using Business.Concrete;
using System;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CarManager cm = new CarManager(new EfCarDal());
            foreach (var cars in cm.GetByCarsColorId(2))
            {
                Console.WriteLine(cars.Name);
            }
        }
    }
}
