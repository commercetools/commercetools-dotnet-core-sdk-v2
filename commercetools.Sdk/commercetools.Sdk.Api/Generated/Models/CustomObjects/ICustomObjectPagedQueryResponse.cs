using commercetools.Api.Models.CustomObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomObjects
{
    [DeserializeAs(typeof(commercetools.Api.Models.CustomObjects.CustomObjectPagedQueryResponse))]
    public partial interface ICustomObjectPagedQueryResponse
    {
        long Limit { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        long Offset { get; set; }

        List<ICustomObject> Results { get; set; }
    }
}
