using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{

    public partial class AttributeGroupUpdate : IAttributeGroupUpdate
    {
        public long Version { get; set; }

        public List<IAttributeGroupUpdateAction> Actions { get; set; }
    }
}
