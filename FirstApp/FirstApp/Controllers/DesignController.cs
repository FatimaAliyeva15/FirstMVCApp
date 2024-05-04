using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class DesignController : Controller
    {
        public IActionResult Index()
        {
            Furniture furniture1 = new Furniture()
            {
                Id = 1,
                Name = "Chair",
                Price = 1399.99
            };

            Furniture furniture2 = new Furniture()
            {
                Id = 2,
                Name = "Sofa",
                Price = 4399.99
            };

            Furniture furniture3 = new Furniture()
            {
                Id = 3,
                Name = "Table",
                Price = 1069.99
            };

            Furniture furniture4 = new Furniture()
            {
                Id = 4,
                Name = "Corner Sofa",
                Price = 2199.99
            };

            Furniture furniture5 = new Furniture()
            {
                Id = 5,
                Name = "Armchair Alzonni Lux",
                Price = 1049.99
            };

            Furniture furniture6 = new Furniture()
            {
                Id = 6,
                Name = "Table Gala Dark",
                Price = 599.99
            };

            Furniture furniture7 = new Furniture()
            {
                Id = 7,
                Name = "Sofa Gala Loft",
                Price = 1069.99
            };

            Furniture furniture8 = new Furniture()
            {
                Id = 8,
                Name = "Armchair Gala Loft",
                Price = 529.99
            };

            Furniture furniture9 = new Furniture()
            {
                Id = 9,
                Name = "Gala Loft Gold Table",
                Price = 599.99
            };

            List<Furniture> furnitures1 = new List<Furniture>();
            List<Furniture> furnitures2 = new List<Furniture>();
            List<Furniture> furnitures3 = new List<Furniture>();

            furnitures1.Add(furniture1);
            furnitures1.Add(furniture2);
            furnitures1.Add(furniture3);
            furnitures2.Add(furniture4);
            furnitures2.Add(furniture5);
            furnitures2.Add(furniture6);
            furnitures3.Add(furniture7);
            furnitures3.Add(furniture8);
            furnitures3.Add(furniture9);


            ViewBag.Carousel1Furnitures = furnitures1;
            ViewBag.Carousel2Furnitures = furnitures2;
            ViewBag.Carousel3Furnitures = furnitures3;

            return View();
        }
    }
}
