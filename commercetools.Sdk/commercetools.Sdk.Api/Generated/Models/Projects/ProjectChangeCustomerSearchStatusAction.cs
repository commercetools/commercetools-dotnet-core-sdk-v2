using commercetools.Sdk.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class ProjectChangeCustomerSearchStatusAction : IProjectChangeCustomerSearchStatusAction
    {
        public string Action { get; set; }

        public ICustomerSearchStatus Status { get; set; }
        public ProjectChangeCustomerSearchStatusAction()
        {
            this.Action = "changeCustomerSearchStatus";
        }
    }
}
