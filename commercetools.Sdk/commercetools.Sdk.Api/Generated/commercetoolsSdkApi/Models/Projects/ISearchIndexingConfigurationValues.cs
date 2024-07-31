using commercetools.Sdk.Api.Models.Common;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.SearchIndexingConfigurationValues))]
    public partial interface ISearchIndexingConfigurationValues
    {
        ISearchIndexingConfigurationStatus Status { get; set; }

        DateTime? LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

    }
}
