using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Lab15._2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab15._2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CategoryController : ControllerBase
    {
        private readonly IDAL dal;

        public CategoryController(IDAL dal)
        {
            this.dal = dal;
        }

        [HttpGet]
        public Object Get()
        {
            var categories = dal.GetMovieCategories();

            if (categories is null)
            {
                return new { success = false };
            }

            return new { success = true, categories };

        }
    }
}