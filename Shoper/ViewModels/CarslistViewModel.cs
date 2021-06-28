using Shoper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoper.ViewModels
{
    public class CarslistViewModel
    {
        public IEnumerable<Car> allCars { get; set; }
        public string CurrCategory { get; set; } 
    }
}
