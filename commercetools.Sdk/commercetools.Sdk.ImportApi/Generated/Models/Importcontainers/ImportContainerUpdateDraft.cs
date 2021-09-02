using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importcontainers
{
    public partial class ImportContainerUpdateDraft : IImportContainerUpdateDraft
    {
        public long Version { get; set; }

        public IImportResourceType ResourceType { get; set; }
    }
}
