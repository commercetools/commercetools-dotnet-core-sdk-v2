using commercetools.Sdk.Api.Models.AttributeGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{

    public partial class AttributeGroupUpdate : IAttributeGroupUpdate
    {
        public long Version { get; set; }

        public IList<IAttributeGroupUpdateAction> Actions { get; set; }
        public IEnumerable<IAttributeGroupUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
