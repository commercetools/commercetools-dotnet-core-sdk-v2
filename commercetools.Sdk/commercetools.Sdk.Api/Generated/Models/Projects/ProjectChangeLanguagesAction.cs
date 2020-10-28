using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    public partial class ProjectChangeLanguagesAction : IProjectChangeLanguagesAction
    {
        public string Action { get; set;}
        
        public List<string> Languages { get; set;}
        public ProjectChangeLanguagesAction()
        { 
           this.Action = "changeLanguages";
        }
    }
}
