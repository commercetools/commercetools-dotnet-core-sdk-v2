using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Searches
{

    public partial class SearchNotExpression : ISearchNotExpression
    {
        public IList<ISearchQuery> Not { get; set; }
        public IEnumerable<ISearchQuery> NotEnumerable { set => Not = value.ToList(); }

    }
}
