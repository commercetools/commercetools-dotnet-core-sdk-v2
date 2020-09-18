using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [Discriminator(nameof(Action))]
    public abstract class ProjectUpdateAction 
    {
        public string Action { get; set;}
    }
}
