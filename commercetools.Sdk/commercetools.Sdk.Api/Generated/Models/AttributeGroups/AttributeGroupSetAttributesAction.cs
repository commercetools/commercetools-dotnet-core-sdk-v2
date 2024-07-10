using commercetools.Sdk.Api.Models.AttributeGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{

    public partial class AttributeGroupSetAttributesAction : IAttributeGroupSetAttributesAction
    {
        public string Action { get; set; }

        public IList<IAttributeReference> Attributes { get; set; }
        public IEnumerable<IAttributeReference> AttributesEnumerable { set => Attributes = value.ToList(); }

        public AttributeGroupSetAttributesAction()
        {
            this.Action = "setAttributes";
        }
    }
}
