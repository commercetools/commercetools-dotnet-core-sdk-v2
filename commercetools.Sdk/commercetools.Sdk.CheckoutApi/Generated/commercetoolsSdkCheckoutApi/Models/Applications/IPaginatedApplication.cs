using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.PaginatedApplication))]
    public partial interface IPaginatedApplication
    {
        int Limit { get; set; }

        int Offset { get; set; }

        int Count { get; set; }

        int Total { get; set; }

        IList<IApplication> Results { get; set; }

        IEnumerable<IApplication> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
