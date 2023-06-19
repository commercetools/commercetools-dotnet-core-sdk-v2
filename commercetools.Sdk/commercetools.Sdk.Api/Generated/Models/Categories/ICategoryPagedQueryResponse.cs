using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategoryPagedQueryResponse))]
    public partial interface ICategoryPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<ICategory> Results { get; set; }
        IEnumerable<ICategory> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
