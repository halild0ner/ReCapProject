﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        
        List<Car> GetAll();
        void Add(Car car);
        List<CarDetailDto> GetCarDetails();



    }
}
