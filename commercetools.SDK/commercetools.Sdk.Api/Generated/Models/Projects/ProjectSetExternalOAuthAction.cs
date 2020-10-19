using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DiscriminatorValue("setExternalOAuth")]
    public partial class ProjectSetExternalOAuthAction : ProjectUpdateAction
    {
        public ExternalOAuth ExternalOAuth { get; set;}
        public ProjectSetExternalOAuthAction()
        { 
           this.Action = "setExternalOAuth";
        }
    }
}
