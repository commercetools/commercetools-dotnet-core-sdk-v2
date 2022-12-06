using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.PagedQueryResponse))]
    public partial interface IPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IBaseResource> Results { get; set; }
        IEnumerable<IBaseResource> ResultsEnumerable { set => Results = value.ToList(); }


        Object Meta { get; set; }

    }
}
