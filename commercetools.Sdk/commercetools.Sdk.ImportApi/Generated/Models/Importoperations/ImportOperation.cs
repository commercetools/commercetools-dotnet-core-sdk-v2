using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Importoperations
{

    public partial class ImportOperation : IImportOperation
    {
        public long Version { get; set; }

        public string ImportContainerKey { get; set; }

        public string ResourceKey { get; set; }

        public string Id { get; set; }

        public IProcessingState State { get; set; }

        public long? ResourceVersion { get; set; }

        public IList<IErrorObject> Errors { get; set; }
        public IEnumerable<IErrorObject> ErrorsEnumerable { set => Errors = value.ToList(); }


        public IList<IUnresolvedReferences> UnresolvedReferences { get; set; }
        public IEnumerable<IUnresolvedReferences> UnresolvedReferencesEnumerable { set => UnresolvedReferences = value.ToList(); }


        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public DateTime ExpiresAt { get; set; }
    }
}
