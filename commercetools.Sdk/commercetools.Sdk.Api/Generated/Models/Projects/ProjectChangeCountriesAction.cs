using commercetools.Sdk.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectChangeCountriesAction : IProjectChangeCountriesAction
    {
        public string Action { get; set; }

        public IList<string> Countries { get; set; }
        public IEnumerable<string> CountriesEnumerable { set => Countries = value.ToList(); }

        public ProjectChangeCountriesAction()
        {
            this.Action = "changeCountries";
        }
    }
}
