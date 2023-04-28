using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {

            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from cs in context.Cars
                             join b in context.Brands
                             on cs.BrandId equals b.Id
                             join c in context.Colors
                             on cs.ColorId equals c.Id
                             select new CarDetailDto
                             {
                                 DailyPrice = cs.DailyPrice,
                                 BrandName = b.Name,
                                 CarName = cs.Name,
                                 ColorName = c.Name,
                                 Id = cs.Id
                             };
                return result.ToList();
            }

        }
    }
}
