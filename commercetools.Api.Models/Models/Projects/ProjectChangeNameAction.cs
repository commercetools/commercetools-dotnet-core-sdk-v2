using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Projects
{
    public class ProjectChangeNameAction : ProjectUpdateAction
    {
        public string Name { get; set;}
    }
}
