﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {   //Veritabanından geliyormuş gibi simule ediyoruz
            _cars = new List<Car> {
                new Car {CarId = 1, BrandId = 1, ColorId = 2, ModelYear = 2021, DailyPrice = 350, Description = "Dizel"},
                new Car {CarId = 2, BrandId = 2, ColorId = 4, ModelYear = 2021, DailyPrice = 250, Description = "Benzin"},
                new Car {CarId = 3, BrandId = 1, ColorId = 5, ModelYear = 2021, DailyPrice = 325, Description = "Dizel"},
                new Car {CarId = 4, BrandId = 3, ColorId = 1, ModelYear = 2010, DailyPrice = 200, Description = "LPG+Benzin"},
                new Car {CarId = 5, BrandId = 5, ColorId = 7, ModelYear = 2016, DailyPrice = 225, Description = "Benzin"},

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

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        

        
        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice; 
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
