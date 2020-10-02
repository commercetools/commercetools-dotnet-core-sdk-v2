using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DiscriminatorValue("changeCountryTaxRateFallbackEnabled")]
    public partial class ProjectChangeCountryTaxRateFallbackEnabledAction : ProjectUpdateAction
    {
        public bool CountryTaxRateFallbackEnabled { get; set;}
        public ProjectChangeCountryTaxRateFallbackEnabledAction()
        { 
           this.Action = "changeCountryTaxRateFallbackEnabled";
        }
    }
}
