using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EntityFrameWorkCarDal : ICarDal
    {
        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByColor(int colorId)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int carId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
