using commercetools.Sdk.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectChangeCurrenciesAction : IProjectChangeCurrenciesAction
    {
        public string Action { get; set; }

        public IList<string> Currencies { get; set; }
        public IEnumerable<string> CurrenciesEnumerable { set => Currencies = value.ToList(); }

        public ProjectChangeCurrenciesAction()
        {
            this.Action = "changeCurrencies";
        }
    }
}
