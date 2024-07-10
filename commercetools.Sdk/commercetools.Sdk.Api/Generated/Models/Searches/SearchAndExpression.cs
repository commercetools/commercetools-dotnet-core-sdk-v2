using commercetools.Sdk.Api.Models.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Searches
{

    public partial class SearchAndExpression : ISearchAndExpression
    {
        public IList<ISearchQuery> And { get; set; }
        public IEnumerable<ISearchQuery> AndEnumerable { set => And = value.ToList(); }

    }
}
