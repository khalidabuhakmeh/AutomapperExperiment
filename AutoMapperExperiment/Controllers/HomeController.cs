using System.Web.Mvc;
using AutoMapperExperiment.Models.Objects;
using AutoMapperExperiment.Models.ViewModels;

namespace AutoMapperExperiment.Controllers
{
    public class HomeController : ApplicationController
    {
        public ActionResult Index()
        {
            var person = new Person
            {
                Name = "Khalid Abuhakmeh",
                Address = new Address { City = "Camp Hill", Street = "111 November Dr" }
            };

            var car = new Car
            {
                Color = "Black",
                Make = "Audi",
                Model = "A4"
            };

            return ViewModel<IndexViewModel>(person, car);
        }
    }
}
