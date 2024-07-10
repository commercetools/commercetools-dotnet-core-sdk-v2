using commercetools.Sdk.Api.Models.AssociateRoles;
using commercetools.Sdk.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Projects
{

    public partial class BusinessUnitConfiguration : IBusinessUnitConfiguration
    {
        public IBusinessUnitConfigurationStatus MyBusinessUnitStatusOnCreation { get; set; }

        public IAssociateRoleKeyReference MyBusinessUnitAssociateRoleOnCreation { get; set; }
    }
}
