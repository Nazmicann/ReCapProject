using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        private List<Car> _cars;
        public InMemoryCarDal()
        {

            _cars = new List<Car>
            {
                new Car {CarId=1,BrandId=2,ColorId=3,DailyPrice=15000,Description="SüperModel Son hızlı",ModelYear=2015},
                new Car {CarId=2,BrandId=1,ColorId=2,DailyPrice=25000,Description="SüperModel Son hızlı",ModelYear=2018},
                new Car {CarId=3,BrandId=4,ColorId=1,DailyPrice=1500,Description="Ağır Kasa",ModelYear=2020},
                new Car {CarId=4,BrandId=3,ColorId=4,DailyPrice=50000,Description="Zırhlı ",ModelYear=2010},
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int categoryId)
        {
            return _cars.Where(c => c.CarId == categoryId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;

        }

        List<Car> ICarDal.GetById()
        {
            throw new NotImplementedException();
        }
    }
}
