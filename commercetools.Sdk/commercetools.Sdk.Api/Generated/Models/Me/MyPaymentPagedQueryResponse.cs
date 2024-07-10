using commercetools.Sdk.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyPaymentPagedQueryResponse : IMyPaymentPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public IList<IMyPayment> Results { get; set; }
        public IEnumerable<IMyPayment> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
