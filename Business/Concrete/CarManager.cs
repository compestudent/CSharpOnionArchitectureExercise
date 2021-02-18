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

        public List<Car> ReturnAll()
        {
            return _carDal.GetAll();
        }

        public Car ReturnAllBySelf(int carId)
        {
            return _carDal.GetById(carId);
        }

        public List<Car> ReturnAllByBrand(int brandId)
        {
            return _carDal.GetAllByBrand(brandId);
        }

        public List<Car> ReturnAllByColor(int colorId)
        {
            return _carDal.GetAllByColor(colorId);
        }
    }
}
