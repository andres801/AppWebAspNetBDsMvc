using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppWebAspNetBDsMvc.Controllers
{
    public class HelloWorldController : Controller
    {
          // 
          // GET: /HelloWorld/ 

          public string Index()
          {
               return "This is my <b>default</b> action...";
          }

          // 
          // GET: /HelloWorld/Bienvenido/ 

          public string Bienvenido()
          {
               return "This is the Bienvenido action method...";
          }

          // 
          // GET: /HelloWorld/Welcome?name=Scott&numtimes=4 

          public string Welcome(string name, int numTimes = 1)
          {
               return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
          }

          // 
          // GET: /HelloWorld/Wilkommen/1?name=Scott

          public string Wilkommen(string name, int ID = 1)
          {
               return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
          }
     }
}