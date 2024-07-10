using commercetools.Sdk.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectUpdate : IProjectUpdate
    {
        public long Version { get; set; }

        public IList<IProjectUpdateAction> Actions { get; set; }
        public IEnumerable<IProjectUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
