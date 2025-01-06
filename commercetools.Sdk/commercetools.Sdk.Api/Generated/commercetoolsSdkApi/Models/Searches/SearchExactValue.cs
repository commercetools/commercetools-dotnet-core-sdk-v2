using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Searches
{

    public partial class SearchExactValue : ISearchExactValue
    {
        public string Field { get; set; }

        public decimal? Boost { get; set; }

        public ISearchFieldType FieldType { get; set; }

        public Object Value { get; set; }

        public IList<Object> Values { get; set; }

        public IEnumerable<Object> ValuesEnumerable { set => Values = value.ToList(); }

        public string Language { get; set; }

        public bool? CaseInsensitive { get; set; }
    }
}
