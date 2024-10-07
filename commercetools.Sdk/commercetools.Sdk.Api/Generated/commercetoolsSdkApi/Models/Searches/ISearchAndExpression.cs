using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchAndExpression))]
    public partial interface ISearchAndExpression : ISearchCompoundExpression
    {
        IList<ISearchQuery> And { get; set; }

        IEnumerable<ISearchQuery> AndEnumerable { set => And = value.ToList(); }

    }
}
