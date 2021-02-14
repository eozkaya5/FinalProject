using Business.Abstract;
using Business.ConCrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]//ATTRIBUTE
    public class ProductsController : ControllerBase
    {
        // Loosely coupled= serbest bağımlılık
        //Naming convertion= isimlendirme standı(alt çizgi kullanımı)
        // IOC__ Invorsion of contrıl
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            // Dependency chain
            //Eğer istek başarılı ise veriyi listelettir değilse hata mesajı göster
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);//Data
            }
            return BadRequest(result);// Messages
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            //Eğer istek başarılı ise veriyi listelettir değilse hata mesajı göster

            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            //Eğer istek başarılı ise veriyi kaydet değilse hata mesajı göster

            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);


        }
    }
}
