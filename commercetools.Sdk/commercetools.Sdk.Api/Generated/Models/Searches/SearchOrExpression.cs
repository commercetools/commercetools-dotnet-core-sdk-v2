using commercetools.Sdk.Api.Models.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Searches
{

    public partial class SearchOrExpression : ISearchOrExpression
    {
        public IList<ISearchQuery> Or { get; set; }
        public IEnumerable<ISearchQuery> OrEnumerable { set => Or = value.ToList(); }

    }
}
