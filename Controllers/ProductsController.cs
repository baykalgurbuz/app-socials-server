using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ServerApp.Models;

namespace ServerApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController:ControllerBase
    {
        private static List<Product> _products;
        public ProductsController()
        {
            _products=new List<Product>();
            _products.Add(new Product(){ProductId=1,Name="Samsung s6",Price=3000,IsActive=false});
            _products.Add(new Product(){ProductId=2,Name="Samsung s7",Price=2000,IsActive=true});
            _products.Add(new Product(){ProductId=3,Name="Samsung s8",Price=5000,IsActive=true});
            _products.Add(new Product(){ProductId=4,Name="Samsung s9",Price=6000,IsActive=false});
            _products.Add(new Product(){ProductId=5,Name="Samsung s10",Price=7000,IsActive=true});
            _products.Add(new Product(){ProductId=6,Name="Samsung s11",Price=3300,IsActive=false});
        }
        [HttpGet]
        public List<Product> GetProducts(){
            return _products;
        }
        [HttpGet]
        public IActionResult GetProduct(int id){
          var p=_products.FirstOrDefault(i=>i.ProductId==id);
          if(p==null){
            return NotFound();
          }
          return Ok(p);
        }
    }
}