using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo4.Models;

namespace Demo4.Controllers
{
    public class HomeController : Controller
    {
        //23.  Add id in viewresult
        //25.  Erase ID
        //29.  Enter params
        public ViewResult Index(string param1, string param2)
        {
            //12.  Create a view bag to test out server time
            //13.  Go to Index.cshtml
            //14.  Create another function
            ViewBag.servertime = DateTime.Now.ToString();


            //Model Binder - Connect data to method
            //26.  Use query string
            //string id = (string)RouteData.Values["id"];

            //27. Use params for multiple params
            //string id1 = (string)RouteData.Values["param1"];
            //string id2 = (string)RouteData.Values["param2"];
            //ViewBag.name = id1 + " " + id2;

            //28.  Try Rude data
            //30.  Use params
            ViewBag.name = param1 + " " + param2;

            //31.  Create method5 for Query String

            //24.  Use id
            //ViewBag.name = id;

            


            //18.  Create a Models Folder
            //19.  Create a Person Class

            //22.  Create Person
            Person obj = new Person();
            obj.PersonId = 100;
            obj.PersonName = "Hung";
            return View(obj);
        }

        //4.  Create a function to return something
        public ContentResult ReturnContent()
        {
            return Content("this is a test from HomeController.cs");
        }
        //5.  Create a Class


        //Returning dummy errors
        public StatusCodeResult Method1()
        {
            //Return logic
            return new StatusCodeResult(404);
        }

        //15.  Go to specific Website
        public RedirectResult OpenGoogle()
        {
            return Redirect("https://www.google.com");
        }
        //16.  Create a method for RedirectToAction
        public RedirectToActionResult Method2()
        {
            return RedirectToAction("OpenGoogle");
        }
        //17.  Create a method for redirect to route
        public RedirectToRouteResult Method3()
        {
            return RedirectToRoute("Other", "Index");
        }

        //32.  Create Method
        public ContentResult Method5(string id)
        {
            return Content("Hello" + id);
        }
    }
}
