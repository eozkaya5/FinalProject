using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : Controller
    {
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            
            var result = _categoryService.GetAll();
            if (result.Success)
            {
                return Ok(result);//Data
            }
            return BadRequest(result);// Messages
        }
    }
}
