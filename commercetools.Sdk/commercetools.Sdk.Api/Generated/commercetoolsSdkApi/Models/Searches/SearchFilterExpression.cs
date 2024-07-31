using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Searches
{

    public partial class SearchFilterExpression : ISearchFilterExpression
    {
        public IList<ISearchQueryExpression> Filter { get; set; }

        public IEnumerable<ISearchQueryExpression> FilterEnumerable { set => Filter = value.ToList(); }
    }
}
