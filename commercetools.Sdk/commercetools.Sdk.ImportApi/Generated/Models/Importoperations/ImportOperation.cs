using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importoperations
{
    public partial class ImportOperation : IImportOperation
    {
        public long Version { get; set; }

        public string ImportContainerKey { get; set; }

        public string ResourceKey { get; set; }

        public string Id { get; set; }

        public IProcessingState State { get; set; }

        public long? ResourceVersion { get; set; }

        public List<IErrorObject> Errors { get; set; }

        public List<IKeyReference> UnresolvedReferences { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public DateTime ExpiresAt { get; set; }
    }
}
