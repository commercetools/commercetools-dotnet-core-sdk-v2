using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Searches
{

    public partial class SearchAndExpression : ISearchAndExpression
    {
        public IList<ISearchQuery> And { get; set; }
        public IEnumerable<ISearchQuery> AndEnumerable { set => And = value.ToList(); }

    }
}
