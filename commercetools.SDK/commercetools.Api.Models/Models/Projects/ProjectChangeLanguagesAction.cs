using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DiscriminatorValue("changeLanguages")]
    public class ProjectChangeLanguagesAction : ProjectUpdateAction
    {
        public List<string> Languages { get; set;}
    }
}
