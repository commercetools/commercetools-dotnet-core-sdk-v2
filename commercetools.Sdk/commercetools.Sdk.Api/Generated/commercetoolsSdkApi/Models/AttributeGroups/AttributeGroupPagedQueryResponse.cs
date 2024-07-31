using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.AttributeGroups
{

    public partial class AttributeGroupPagedQueryResponse : IAttributeGroupPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IAttributeGroup> Results { get; set; }

        public IEnumerable<IAttributeGroup> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
