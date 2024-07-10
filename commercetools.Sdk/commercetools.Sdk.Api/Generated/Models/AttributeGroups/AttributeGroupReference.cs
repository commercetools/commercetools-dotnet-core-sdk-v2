using commercetools.Sdk.Api.Models.AttributeGroups;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{

    public partial class AttributeGroupReference : IAttributeGroupReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IAttributeGroup Obj { get; set; }
        public AttributeGroupReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("attribute-group");
        }
    }
}
