using commercetools.Sdk.Api.Models.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Searches
{

    public partial class SearchNotExpression : ISearchNotExpression
    {
        public IList<ISearchQuery> Not { get; set; }
        public IEnumerable<ISearchQuery> NotEnumerable { set => Not = value.ToList(); }

    }
}
