using System.Collections.Generic;


namespace commercetools.Api.Models.Types
{
    public partial class TypePagedQueryResponse : ITypePagedQueryResponse
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public List<IType> Results { get; set; }
    }
}
