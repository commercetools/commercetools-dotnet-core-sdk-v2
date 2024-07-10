using commercetools.Sdk.Api.Models.CustomObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.CustomObjects
{

    public partial class CustomObjectPagedQueryResponse : ICustomObjectPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<ICustomObject> Results { get; set; }
        public IEnumerable<ICustomObject> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
