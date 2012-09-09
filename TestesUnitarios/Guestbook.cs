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
        private HomeController controller;
        [TestCase]
        public void Index()
        {
            ViewResult result = controller.Index() as ViewResult;

            Assert.AreEqual("Modify this template to jump-start your ASP.NET MVC application.", (string) result.ViewBag.Message);
        }

        [TestCase]
        public void About()
        {
            ViewResult result = controller.About() as ViewResult;

            Assert.NotNull(result);
        }

        [SetUp]
        public void Up()
        {
            this.controller = new HomeController();
        }
    }
}
