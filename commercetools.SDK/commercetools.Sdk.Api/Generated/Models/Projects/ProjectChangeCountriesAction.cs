using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DiscriminatorValue("changeCountries")]
    public partial class ProjectChangeCountriesAction : ProjectUpdateAction
    {
        public List<string> Countries { get; set;}
        public ProjectChangeCountriesAction()
        { 
           this.Action = "changeCountries";
        }
    }
}
