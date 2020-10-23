using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    public  partial class ProjectChangeCurrenciesAction : IProjectChangeCurrenciesAction
    {
        public string Action { get; set;}
        
        public List<string> Currencies { get; set;}
        public ProjectChangeCurrenciesAction()
        { 
           this.Action = "changeCurrencies";
        }
    }
}
