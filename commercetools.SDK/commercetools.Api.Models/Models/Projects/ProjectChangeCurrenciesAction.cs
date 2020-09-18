using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DiscriminatorValue("changeCurrencies")]
    public class ProjectChangeCurrenciesAction : ProjectUpdateAction
    {
        public List<string> Currencies { get; set;}
    }
}
