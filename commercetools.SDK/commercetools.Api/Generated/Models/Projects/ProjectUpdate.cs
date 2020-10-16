using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Projects
{
    public partial class ProjectUpdate 
    {
        public long Version { get; set;}
        
        public List<ProjectUpdateAction> Actions { get; set;}
    }
}
