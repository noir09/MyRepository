using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shoper.Data.interfaces;
using Shoper.Data.Models;

namespace Shoper.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars 
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name= "Tesla model s",
                        shortdesc="быстрый автомобиль",
                        longdesc="красивый быстрый и тихий автомобиль",
                        img="/img/tesla.jpg",
                        prace=45000,
                        isFavourite=true,
                        ivailable=true,
                        Category= _categoryCars.AllCategories.First()
                    },
                   new Car
                    {
                        name= "Fond fiesta",
                        shortdesc="тихий и удобный",
                        longdesc="удобный автомобиль для городской жизни",
                        img="/img/загружено.jpg",
                        prace=11000,
                        isFavourite=false,
                        ivailable=true,
                        Category= _categoryCars.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carID)
        {
            throw new NotImplementedException();
        }
    }
}
