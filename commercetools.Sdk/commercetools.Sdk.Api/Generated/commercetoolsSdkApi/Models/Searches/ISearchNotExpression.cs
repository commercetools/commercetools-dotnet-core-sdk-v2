using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchNotExpression))]
    public partial interface ISearchNotExpression : ISearchCompoundExpression
    {
        IList<ISearchQuery> Not { get; set; }

        IEnumerable<ISearchQuery> NotEnumerable { set => Not = value.ToList(); }

    }
}
