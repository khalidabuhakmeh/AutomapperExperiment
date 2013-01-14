using System.Web.Mvc;
using AutoMapper;

namespace AutoMapperExperiment.Controllers
{
    public abstract class ApplicationController : Controller
    {
        protected virtual ActionResult ViewModel<T>(string view, params object[] models) where T : new()
        {
            object viewmodel = new T();

            foreach (object model in models)
                Mapper.Map(model, viewmodel, model.GetType(), typeof(T));

            return View(view, viewmodel);
        }

        protected virtual ActionResult ViewModel<T>(params object[] models) where T : new()
        {
            return ViewModel<T>(null, models);
        }

    }
}
