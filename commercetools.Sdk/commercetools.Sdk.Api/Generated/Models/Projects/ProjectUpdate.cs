using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    public partial class ProjectUpdate : IProjectUpdate
    {
        public long Version { get; set;}
        
        public List<IProjectUpdateAction> Actions { get; set;}
    }
}
