using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DiscriminatorValue("changeName")]
    public partial class ProjectChangeNameAction : ProjectUpdateAction
    {
        public string Name { get; set;}
        public ProjectChangeNameAction()
        { 
           this.Action = "changeName";
        }
    }
}
