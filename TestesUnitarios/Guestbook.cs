using System;
using NUnit.Framework;
using HelloWorld.Controllers;
using System.Web.Mvc;
using System.Web;

namespace TestesUnitarios
{
    [TestFixture]
    public class Guestbook
    {
        [TestCase]
        public void Index()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.AreEqual("Modify this template to jump-start your ASP.NET MVC application.", (string) result.ViewBag.Message);
        }
    }
}
