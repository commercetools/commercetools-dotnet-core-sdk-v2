using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyPaymentPagedQueryResponse))]
    public partial interface IMyPaymentPagedQueryResponse
    {
        long Limit { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        long Offset { get; set; }

        IList<IMyPayment> Results { get; set; }
        IEnumerable<IMyPayment> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
