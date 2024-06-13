using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetail())
            {
                Console.WriteLine("{0} - {1} - {2} - {3} - {4} ",car.CarId,car.ColorName,car.BrandName,car.DailyPrice,car.Description);
            }

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car() { CarId = 11, BrandId = 3, ColorId = 2, DailyPrice = 200, Description = "Porshe911", ModelYear = 2022 };
            carManager.Add(car1);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id : " + car.CarId + " Color Id : " +
                    car.ColorId + " Brand Id : " +
                    car.BrandId + " Model Year : " +
                    car.ModelYear + " Description : " +
                    car.Description + "\n------------------------------\n");
            }
            Console.WriteLine("GET BY ID");
            Console.WriteLine(carManager.GetById(4).CarId);
            carManager.Delete(car1);
            Car car2 = new Car() { CarId = 3, BrandId = 55, Description = "Güncellendi!", ColorId = 12, DailyPrice = 900, ModelYear = 2024 };
            carManager.Update(car2);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id : " + car.CarId + " Color Id : " +
                    car.ColorId + " Brand Id : " +
                    car.BrandId + " Model Year : " +
                    car.ModelYear + " Description : " +
                    car.Description + "\n------------------------------\n");
            }
        }
    }
}
