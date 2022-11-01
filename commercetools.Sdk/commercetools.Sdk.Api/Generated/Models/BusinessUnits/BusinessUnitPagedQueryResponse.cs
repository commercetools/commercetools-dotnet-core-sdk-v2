using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitPagedQueryResponse : IBusinessUnitPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public List<IBusinessUnit> Results { get; set; }
    }
}
