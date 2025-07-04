using commercetools.Sdk.ImportApi.Models.Common;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importcontainers
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importcontainers.ImportContainer))]
    public partial interface IImportContainer
    {
        string Key { get; set; }

        IImportResourceType ResourceType { get; set; }

        long Version { get; set; }

        IRetentionPolicy RetentionPolicy { get; set; }

        DateTime CreatedAt { get; set; }

        DateTime LastModifiedAt { get; set; }

        DateTime? ExpiresAt { get; set; }

    }
}
