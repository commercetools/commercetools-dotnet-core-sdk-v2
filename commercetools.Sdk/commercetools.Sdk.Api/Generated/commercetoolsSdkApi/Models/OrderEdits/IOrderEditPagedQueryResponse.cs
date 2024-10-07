using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditPagedQueryResponse))]
    public partial interface IOrderEditPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IOrderEdit> Results { get; set; }

        IEnumerable<IOrderEdit> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
