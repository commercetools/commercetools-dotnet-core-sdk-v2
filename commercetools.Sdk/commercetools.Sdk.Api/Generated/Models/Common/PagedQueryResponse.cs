using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Common
{

    public partial class PagedQueryResponse : IPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IBaseResource> Results { get; set; }
        public IEnumerable<IBaseResource> ResultsEnumerable { set => Results = value.ToList(); }


        public Object Meta { get; set; }
    }
}
