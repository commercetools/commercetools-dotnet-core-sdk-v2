using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importoperations
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importoperations.ImportOperation))]
    public partial interface IImportOperation
    {
        long Version { get; set; }

        string ImportContainerKey { get; set; }

        string ResourceKey { get; set; }

        string Id { get; set; }

        IProcessingState State { get; set; }

        long? ResourceVersion { get; set; }

        IList<IErrorObject> Errors { get; set; }
        IEnumerable<IErrorObject> ErrorsEnumerable { set => Errors = value.ToList(); }


        IList<IUnresolvedReferences> UnresolvedReferences { get; set; }
        IEnumerable<IUnresolvedReferences> UnresolvedReferencesEnumerable { set => UnresolvedReferences = value.ToList(); }


        DateTime CreatedAt { get; set; }

        DateTime LastModifiedAt { get; set; }

        DateTime ExpiresAt { get; set; }

    }
}
