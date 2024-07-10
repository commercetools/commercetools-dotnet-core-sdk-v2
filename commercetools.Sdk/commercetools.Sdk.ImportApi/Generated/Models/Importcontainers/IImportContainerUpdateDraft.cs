using commercetools.Sdk.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importcontainers
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importcontainers.ImportContainerUpdateDraft))]
    public partial interface IImportContainerUpdateDraft
    {
        long Version { get; set; }

        IImportResourceType ResourceType { get; set; }

    }
}
