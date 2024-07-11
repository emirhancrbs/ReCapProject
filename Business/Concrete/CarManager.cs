using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public IResult Add(Car car)
        {
            if (car.DailyPrice<0 && car.Description.Length<2)
            {
                return new ErrorResult(Messages.CarError);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.Added);
           
        }

        public IResult DeleteById(int id)
        {
            var deletedCar = _carDal.Get(c => c.CarId == id);
            _carDal.Delete(deletedCar);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.Read);
        }

        public IDataResult<Car> GetById(int id)
        {
           return new SuccessDataResult<Car> (_carDal.Get(c=>c.CarId == id),"Getirdi");
        }

        public IDataResult< List<CarDetailDto>> GetCarDetail()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetail());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(c=>c.BrandId== brandId));
        }

        public IDataResult< List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.ColorId==colorId));
        }

        public IResult Update(Car car)
        {
            if (car.DailyPrice < 0 && car.Description.Length < 2)
            {
                return new ErrorResult(Messages.CarError);
            }
            _carDal.Update(car);
            return new SuccessResult(Messages.Added);
        }
    }
}
