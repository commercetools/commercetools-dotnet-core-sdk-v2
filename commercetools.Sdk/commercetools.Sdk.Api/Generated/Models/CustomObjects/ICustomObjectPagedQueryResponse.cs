using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CustomObjects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CustomObjects.CustomObjectPagedQueryResponse))]
    public partial interface ICustomObjectPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        List<ICustomObject> Results { get; set; }
    }
}
