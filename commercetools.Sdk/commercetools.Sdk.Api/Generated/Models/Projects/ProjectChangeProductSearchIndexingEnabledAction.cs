using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    public partial class ProjectChangeProductSearchIndexingEnabledAction : IProjectChangeProductSearchIndexingEnabledAction
    {
        public string Action { get; set; }

        public bool Enabled { get; set; }
        public ProjectChangeProductSearchIndexingEnabledAction()
        {
            this.Action = "changeProductSearchIndexingEnabled";
        }
    }
}
