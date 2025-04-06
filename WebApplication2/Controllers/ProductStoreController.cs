using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    public class ProductStoreController : Controller
    {
        private readonly ApplicationDBContext _dbContext;

        public ProductStoreController(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            _dbContext.products.Add(product);
            _dbContext.SaveChanges();
            return View();
        }
    }
}
