using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.MLApi.Models.ImageSearchConfigs
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.ImageSearchConfigs.ImageSearchConfigResponse))]
    public partial interface IImageSearchConfigResponse
    {
        IImageSearchConfigStatus Status { get; set; }

        DateTime LastModifiedAt { get; set; }

    }
}
