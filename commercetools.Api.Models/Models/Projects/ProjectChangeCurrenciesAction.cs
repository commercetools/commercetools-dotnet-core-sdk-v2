using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Projects
{
    public class ProjectChangeCurrenciesAction : ProjectUpdateAction
    {
        public List<string> Currencies { get; set;}
    }
}
