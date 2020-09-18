using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DiscriminatorValue("changeCountries")]
    public class ProjectChangeCountriesAction : ProjectUpdateAction
    {
        public List<string> Countries { get; set;}
    }
}
