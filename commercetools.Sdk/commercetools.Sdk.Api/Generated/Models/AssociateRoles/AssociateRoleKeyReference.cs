using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.AssociateRoles
{

    public partial class AssociateRoleKeyReference : IAssociateRoleKeyReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Key { get; set; }
        public AssociateRoleKeyReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("associate-role");
        }
    }
}
