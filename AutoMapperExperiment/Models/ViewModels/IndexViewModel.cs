using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapperExperiment.Models.ViewModels
{
    public class IndexViewModel
    {
        public string Name { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }

        public string CarColor { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
    }
}