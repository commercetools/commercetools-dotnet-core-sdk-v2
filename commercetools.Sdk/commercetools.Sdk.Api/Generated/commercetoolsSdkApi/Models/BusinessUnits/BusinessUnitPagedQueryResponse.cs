using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitPagedQueryResponse : IBusinessUnitPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IBusinessUnit> Results { get; set; }

        public IEnumerable<IBusinessUnit> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
