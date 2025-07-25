using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurrencePolicies.RecurrencePolicyPagedQueryResponse))]
    public partial interface IRecurrencePolicyPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IRecurrencePolicy> Results { get; set; }

        IEnumerable<IRecurrencePolicy> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
