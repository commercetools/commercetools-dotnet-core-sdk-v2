using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionPagedQueryResponse))]
    public partial interface IExtensionPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IExtension> Results { get; set; }
        IEnumerable<IExtension> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
