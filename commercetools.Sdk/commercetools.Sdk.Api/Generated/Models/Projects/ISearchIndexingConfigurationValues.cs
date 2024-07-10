using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

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
