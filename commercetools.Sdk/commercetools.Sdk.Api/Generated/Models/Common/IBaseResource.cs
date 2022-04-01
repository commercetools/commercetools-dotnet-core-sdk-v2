using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.BaseResource))]
    public partial interface IBaseResource
    {
        string Id { get; set; }

        long Version { get; set; }

        DateTime CreatedAt { get; set; }

        DateTime LastModifiedAt { get; set; }
    }
}
