using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarProjectDbContext>, IRentalDal
    {
        public bool CheckRental(int carId)
        {
            using (CarProjectDbContext context = new CarProjectDbContext())
            {
                var result = from rental in context.Rentals
                             where rental.CarId == carId &&
                             rental.ReturnDate == null
                             select rental;
                return result.Any();
            }
        }
    }
}
