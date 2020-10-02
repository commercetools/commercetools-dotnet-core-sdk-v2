using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DiscriminatorValue("changeLanguages")]
    public partial class ProjectChangeLanguagesAction : ProjectUpdateAction
    {
        public List<string> Languages { get; set;}
        public ProjectChangeLanguagesAction()
        { 
           this.Action = "changeLanguages";
        }
    }
}
