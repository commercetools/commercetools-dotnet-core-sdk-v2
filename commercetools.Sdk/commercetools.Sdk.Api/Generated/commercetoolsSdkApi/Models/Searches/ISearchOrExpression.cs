using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchOrExpression))]
    public partial interface ISearchOrExpression : ISearchCompoundExpression
    {
        IList<ISearchQuery> Or { get; set; }
        IEnumerable<ISearchQuery> OrEnumerable { set => Or = value.ToList(); }


    }
}
