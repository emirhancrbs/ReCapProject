using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>() {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=150,ModelYear=2021,Description="Bmw 2021 model " },
                new Car{Id=2,BrandId=1,ColorId=1,DailyPrice=100,ModelYear=2022,Description="Bmw 2022 model " },
                new Car{Id=3,BrandId=1,ColorId=2,DailyPrice=250,ModelYear=2021,Description="Audi 2021 model " },
                new Car{Id=4,BrandId=2,ColorId=3,DailyPrice=250,ModelYear=2023,Description="Audi 2023 model " },
                new Car{Id=5,BrandId=2,ColorId=3,DailyPrice=100,ModelYear=2024,Description="Porshe 2024 model " },
                new Car{Id=6,BrandId=3,ColorId=4,DailyPrice=129,ModelYear=2023,Description="Porshe 2023 model " }
            };
            
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(_car=>_car.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int carId)
        {
            var result= _cars.Find(c => c.Id == carId);
            return result;
        }

        public void Update(Car car)
        {
            Car updatedCar = _cars.FirstOrDefault(c=>c.Id==car.Id);
            updatedCar.Description = car.Description;
            updatedCar.DailyPrice=car.DailyPrice;
            updatedCar.ModelYear=car.ModelYear;
            updatedCar.BrandId=car.BrandId;
            updatedCar.ColorId=car.ColorId;
           
        }
    }
}
