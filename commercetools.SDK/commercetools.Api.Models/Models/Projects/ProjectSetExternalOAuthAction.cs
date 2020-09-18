using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DiscriminatorValue("setExternalOAuth")]
    public class ProjectSetExternalOAuthAction : ProjectUpdateAction
    {
        public ExternalOAuth ExternalOAuth { get; set;}
    }
}
