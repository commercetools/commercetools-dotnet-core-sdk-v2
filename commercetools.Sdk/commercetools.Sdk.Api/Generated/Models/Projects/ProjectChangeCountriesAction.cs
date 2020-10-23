using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    public  partial class ProjectChangeCountriesAction : IProjectChangeCountriesAction
    {
        public string Action { get; set;}
        
        public List<string> Countries { get; set;}
        public ProjectChangeCountriesAction()
        { 
           this.Action = "changeCountries";
        }
    }
}
