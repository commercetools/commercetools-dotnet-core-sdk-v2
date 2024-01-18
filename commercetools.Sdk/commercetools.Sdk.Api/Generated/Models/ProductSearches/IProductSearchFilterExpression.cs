using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFilterExpression))]
    public partial interface IProductSearchFilterExpression : IProductSearchCompoundExpression
    {
        IList<IProductSearchQueryExpression> Filter { get; set; }
        IEnumerable<IProductSearchQueryExpression> FilterEnumerable { set => Filter = value.ToList(); }


    }
}
