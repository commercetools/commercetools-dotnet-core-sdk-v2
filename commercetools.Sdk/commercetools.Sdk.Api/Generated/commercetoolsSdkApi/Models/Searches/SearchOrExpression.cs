using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Searches
{

    public partial class SearchOrExpression : ISearchOrExpression
    {
        public IList<ISearchQuery> Or { get; set; }

        public IEnumerable<ISearchQuery> OrEnumerable { set => Or = value.ToList(); }
    }
}
