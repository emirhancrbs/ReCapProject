﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
            Console.WriteLine(" Added Car | Id :  " + car.Id);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine(" Deleted Car | Id :  " + car.Id);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
           return _carDal.GetById(id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine(" Updated Car | Id :  " + car.Id);
        }
    }
}
