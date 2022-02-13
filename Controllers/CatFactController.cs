using CatFactNetwise.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatFactNetwise.Controllers
{
    public class CatFactController : Controller
    {
        protected ICatFactService _service;
        public CatFactController(ICatFactService service)
        {
            service = _service;
        }

    }
}
