using Microsoft.AspNetCore.Mvc;
using Shoper.Data.interfaces;
using Shoper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoper.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        public ViewResult List()
        {
            ViewBag.Title="Страница с автомобилями";
            CarslistViewModel obj = new CarslistViewModel();
            obj.allCars = _allCars.Cars;
            obj.CurrCategory = "Автомобили";
            return View(obj);
        }
    }
}   
