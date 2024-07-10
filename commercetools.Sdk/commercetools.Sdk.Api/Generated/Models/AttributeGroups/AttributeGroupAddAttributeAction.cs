using commercetools.Sdk.Api.Models.AttributeGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{

    public partial class AttributeGroupAddAttributeAction : IAttributeGroupAddAttributeAction
    {
        public string Action { get; set; }

        public IAttributeReference Attribute { get; set; }
        public AttributeGroupAddAttributeAction()
        {
            this.Action = "addAttribute";
        }
    }
}
