using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchAndExpression))]
    public partial interface IProductSearchAndExpression : IProductSearchCompoundExpression
    {
        IList<IProductSearchQuery> And { get; set; }
        IEnumerable<IProductSearchQuery> AndEnumerable { set => And = value.ToList(); }


    }
}
