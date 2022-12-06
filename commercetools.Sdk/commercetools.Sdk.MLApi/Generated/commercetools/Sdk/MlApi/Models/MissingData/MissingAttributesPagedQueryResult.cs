using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class MissingAttributesPagedQueryResult : IMissingAttributesPagedQueryResult
    {
        public long Count { get; set; }

        public long Total { get; set; }

        public long Offset { get; set; }

        public IList<IMissingAttributes> Results { get; set; }
        public IEnumerable<IMissingAttributes> ResultsEnumerable { set => Results = value.ToList(); }


        [ObsoleteAttribute("This property is obsolete", false)]
        public IMissingAttributesMeta Meta { get; set; }
    }
}
