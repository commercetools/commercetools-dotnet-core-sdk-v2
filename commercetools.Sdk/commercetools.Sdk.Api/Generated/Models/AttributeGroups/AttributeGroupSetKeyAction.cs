using commercetools.Sdk.Api.Models.AttributeGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{

    public partial class AttributeGroupSetKeyAction : IAttributeGroupSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public AttributeGroupSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
