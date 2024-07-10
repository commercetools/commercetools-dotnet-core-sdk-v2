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

    public partial class AttributeGroupChangeNameAction : IAttributeGroupChangeNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public AttributeGroupChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
