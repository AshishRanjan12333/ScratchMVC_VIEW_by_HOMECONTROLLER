using Microsoft.AspNetCore.Mvc;
using ScratchMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScratchMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            Student ob = new Student()
            {
                Id = 1,
              name = "Ashish RAnjan",
              email="ashish@gmail.com",
              roll=1
            };
            Student ob1 = new Student()
            {
                Id = 2,
                name = " RAnjan",
                email = "ashish@gmail.com",
                roll = 2
            };
            Student ob2 = new Student()
            {
                Id = 3,
                name = "Ashish ",
                email = "ashish@gmail.com",
                roll = 3
            };
            Student ob3 = new Student()
            {
                Id = 4,
                name = "Ashish Raj",
                email = "ashish@gmail.com",
                roll = 4
            };
            List<Student> std = new List<Student>();
            std.Add(ob);
            std.Add(ob1);
            std.Add(ob2);
            std.Add(ob3);
            return View(std);

        } 
        public IActionResult About()
        {
            return View();
        }
        
    }
}
