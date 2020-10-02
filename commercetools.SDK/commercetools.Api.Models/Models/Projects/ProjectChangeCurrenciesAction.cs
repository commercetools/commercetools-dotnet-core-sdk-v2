using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DiscriminatorValue("changeCurrencies")]
    public partial class ProjectChangeCurrenciesAction : ProjectUpdateAction
    {
        public List<string> Currencies { get; set;}
        public ProjectChangeCurrenciesAction()
        { 
           this.Action = "changeCurrencies";
        }
    }
}
