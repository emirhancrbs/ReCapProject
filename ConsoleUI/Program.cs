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
            CarTest();
            //CarDetailTest();

        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetail();
            foreach (var car in result.Data)
            {
                Console.WriteLine("{0} - {1} - {2} - {3} - {4} ", car.CarId, car.ColorName, car.BrandName, car.DailyPrice, car.Description);
            }
            Console.WriteLine(result.Message);
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car() {  BrandId = 3, ColorId = 2, DailyPrice = 200, Description = "Porshe911", ModelYear = 2022 };
            carManager.Add(car1);
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("Id : " + car.CarId + " Color Id : " +
                    car.ColorId + " Brand Id : " +
                    car.BrandId + " Model Year : " +
                    car.ModelYear + " Description : " +
                    car.Description + "\n------------------------------\n");
            }
            Console.WriteLine("GET BY ID");
            Console.WriteLine(carManager.GetById(4).Data.CarId);
            int deletedcar=Convert.ToInt32( Console.ReadLine());
            carManager.DeleteById(deletedcar);
            Car car2 = new Car() { CarId = 3, BrandId = 7, Description = "Güncellendi!", ColorId = 7, DailyPrice = 9700, ModelYear = 2024 };
            Console.WriteLine(carManager.Update(car2).Message);
            foreach (var car in carManager.GetAll().Data)
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
