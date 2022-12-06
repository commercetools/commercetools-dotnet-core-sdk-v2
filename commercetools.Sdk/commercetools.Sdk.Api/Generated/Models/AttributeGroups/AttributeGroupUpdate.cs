using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{

    public partial class AttributeGroupUpdate : IAttributeGroupUpdate
    {
        public long Version { get; set; }

        public IList<IAttributeGroupUpdateAction> Actions { get; set; }
        public IEnumerable<IAttributeGroupUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
