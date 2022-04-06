using System.Collections.Generic;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    public partial class MissingAttributesPagedQueryResult : IMissingAttributesPagedQueryResult
    {
        public long Count { get; set; }

        public long Total { get; set; }

        public long Offset { get; set; }

        public List<IMissingAttributes> Results { get; set; }

        public IMissingAttributesMeta Meta { get; set; }
    }
}
