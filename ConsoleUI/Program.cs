using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager= new CarManager(new InMemoryCarDal());
            Car car1= new Car() {Id=7,BrandId=3,ColorId=2,DailyPrice=200,Description="Porshe911",ModelYear=2022 };
            carManager.Add(car1);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id : "+car.Id+" Color Id : "+
                    car.ColorId+" Brand Id : "+
                    car.BrandId+" Model Year : "+
                    car.ModelYear+" Description : "+
                    car.Description+"\n------------------------------\n");
            }
            Console.WriteLine("GET BY ID");
            foreach (var item in carManager.GetById(2))
            {
                Console.WriteLine("Id : "+item.Id+" Description : "+ item.Description+"\n");
            }
            carManager.Delete(car1);
            Car car2 = new Car() { Id = 3, BrandId = 55, Description = "Güncellendi!", ColorId = 12, DailyPrice = 900, ModelYear = 2024 };
            carManager.Update(car2);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id : " + car.Id + " Color Id : " +
                    car.ColorId + " Brand Id : " +
                    car.BrandId + " Model Year : " +
                    car.ModelYear + " Description : " +
                    car.Description + "\n------------------------------\n");
            }
            
            
        }
    }
}
