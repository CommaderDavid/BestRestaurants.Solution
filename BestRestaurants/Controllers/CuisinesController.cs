using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using BestRestaurants.Models;

namespace BestRestaurants.Controllers
{
    public class CuisinesController : Controller
    {
         private readonly BestRestaurantsContext _db;

         public CuisinesController(BestRestaurantsContext db)
         {
             _db = db;
         }

         public ActionResult Index()
         {
            List<Cuisine> model = _db.Cuisines.Include(cuisine => cuisine.CuisineName).ToList();
            return View(model);
         }

         
    }
}