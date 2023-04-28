using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            new Car{Id =1,BrandId = 1,ColorId =1,DailyPrice = 300,Description = "Car1",ModelYear = 2020},
            new Car{Id =2,BrandId = 1,ColorId =2,DailyPrice = 450,Description = "Car2",ModelYear = 2021},
            new Car{Id =3,BrandId = 1,ColorId =3,DailyPrice = 250,Description = "Car3",ModelYear = 2022},
            new Car{Id =4,BrandId = 2,ColorId =2,DailyPrice = 500,Description = "Car4",ModelYear = 2023},
            new Car{Id =5,BrandId = 2,ColorId =1,DailyPrice = 600,Description = "Car5",ModelYear = 2023},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carsToDelete = _cars.SingleOrDefault(x => x.Id == car.Id);
            _cars.Remove(carsToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars.ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public int GetById(Car car)
        {
            return car.Id;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(x => x.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
