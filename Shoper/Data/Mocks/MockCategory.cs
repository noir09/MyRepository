using Shoper.Data.interfaces;
using Shoper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoper.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{categoryName= "Электромобили", desc="Современный вид транспорта"},
                    new Category{categoryName= "Класические автомобили", desc="Машины с двигателем внутренего сгорания"}
                };
            }

        }
    }
}
