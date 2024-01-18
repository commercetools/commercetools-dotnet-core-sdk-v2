using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchNotExpression))]
    public partial interface IProductSearchNotExpression : IProductSearchCompoundExpression
    {
        IList<IProductSearchQuery> Not { get; set; }
        IEnumerable<IProductSearchQuery> NotEnumerable { set => Not = value.ToList(); }


    }
}
