using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchOrExpression))]
    public partial interface IProductSearchOrExpression : IProductSearchCompoundExpression
    {
        IList<IProductSearchQuery> Or { get; set; }
        IEnumerable<IProductSearchQuery> OrEnumerable { set => Or = value.ToList(); }


    }
}
