using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    public  partial class ProjectSetExternalOAuthAction : IProjectSetExternalOAuthAction
    {
        public string Action { get; set;}
        
        public IExternalOAuth ExternalOAuth { get; set;}
        public ProjectSetExternalOAuthAction()
        { 
           this.Action = "setExternalOAuth";
        }
    }
}
