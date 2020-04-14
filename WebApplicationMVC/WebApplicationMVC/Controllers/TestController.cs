using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{

    public class TestController : Controller
    {

        public IActionResult Index()
        {

            // 1
            ViewData["email"] = "youef-f@gmail.com";

            //2
            ViewBag.telephone = "0410101010";

            //3
            IList<string> itemsNom = new List<string>();
            itemsNom.Add("mohamed");
            itemsNom.Add("youcef");
            itemsNom.Add("karim");
            itemsNom.Add("fatima");



            return View(itemsNom); // par defaut revoi le nom de la methode "index" avec itemsNom

        }


        public IActionResult Home()
        {
            return View(); // par defaut revoi le nom de la methode "index"
        }

        public IActionResult List()
        {

            IList<Student> students = new List<Student>();
            students.Add(new Student{StudentId=1,Name="Hassan",Score=59 } );
            students.Add(new Student{StudentId=2,Name="Imane",Score=45 } );
            students.Add(new Student{StudentId=3,Name="Mohamed",Score=66 } );

            return View(students); // par defaut revoi le nom de la methode "index"
        }

        public IActionResult B()
        {
            return View("BB"); // par defaut revoi le nom de la methode "index"
        }


    }

}