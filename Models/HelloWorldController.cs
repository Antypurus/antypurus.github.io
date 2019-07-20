using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Website.Models
{
    public class HelloWorldController : Controller
    {
        public String Index()
        {
            return "Hello World";
        }
    }
}