using commercetools.Sdk.Api.Models.AssociateRoles;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.AssociateRoles
{

    public partial class AssociateRoleReference : IAssociateRoleReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IAssociateRole Obj { get; set; }
        public AssociateRoleReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("associate-role");
        }
    }
}
