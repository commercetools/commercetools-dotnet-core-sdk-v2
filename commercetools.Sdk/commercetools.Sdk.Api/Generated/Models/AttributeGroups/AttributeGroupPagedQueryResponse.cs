using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{

    public partial class AttributeGroupPagedQueryResponse : IAttributeGroupPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public List<IAttributeGroup> Results { get; set; }
    }
}
