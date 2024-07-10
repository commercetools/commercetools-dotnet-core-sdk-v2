using commercetools.Sdk.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectChangeCartsConfigurationAction : IProjectChangeCartsConfigurationAction
    {
        public string Action { get; set; }

        public ICartsConfiguration CartsConfiguration { get; set; }
        public ProjectChangeCartsConfigurationAction()
        {
            this.Action = "changeCartsConfiguration";
        }
    }
}
