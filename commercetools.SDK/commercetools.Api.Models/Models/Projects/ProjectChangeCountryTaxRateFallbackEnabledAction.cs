using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DiscriminatorValue("changeCountryTaxRateFallbackEnabled")]
    public class ProjectChangeCountryTaxRateFallbackEnabledAction : ProjectUpdateAction
    {
        public bool CountryTaxRateFallbackEnabled { get; set;}
    }
}
