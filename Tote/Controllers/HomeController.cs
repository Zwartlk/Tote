using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tote.Models;
using System.Data.Entity;

namespace Tote.Controllers
{
    public class HomeController : Controller
    {
        AmadoEntities amado = new AmadoEntities();
        public ActionResult Index()
        {
            return View(amado.Products.ToList());
        }

        //Get Gatogory & Brand
        public class CatogoryBrandModel
        {
            public DbSet<Catagory> Category { get; set; }
            public DbSet<Brand> Brand { get; set; }
        }
        public ActionResult Shop()
        {
            var viewModel = new CatogoryBrandModel();
            viewModel.Category = amado.Catagories;
            viewModel.Brand = amado.Brands;
            return View(viewModel);
        }
    }
}