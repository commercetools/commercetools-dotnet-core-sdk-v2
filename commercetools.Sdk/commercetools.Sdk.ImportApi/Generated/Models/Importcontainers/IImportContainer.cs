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
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importcontainers.ImportContainer))]
    public partial interface IImportContainer
    {
        string Key { get; set; }

        IImportResourceType ResourceType { get; set; }

        long Version { get; set; }

        DateTime CreatedAt { get; set; }

        DateTime LastModifiedAt { get; set; }

    }
}
