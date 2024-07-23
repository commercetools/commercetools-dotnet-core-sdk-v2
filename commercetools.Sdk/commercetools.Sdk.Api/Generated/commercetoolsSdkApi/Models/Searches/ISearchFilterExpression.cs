using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchFilterExpression))]
    public partial interface ISearchFilterExpression : ISearchCompoundExpression
    {
        IList<ISearchQueryExpression> Filter { get; set; }
        IEnumerable<ISearchQueryExpression> FilterEnumerable { set => Filter = value.ToList(); }


    }
}
