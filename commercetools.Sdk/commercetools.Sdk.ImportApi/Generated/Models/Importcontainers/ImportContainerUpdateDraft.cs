using commercetools.Sdk.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Importcontainers
{

    public partial class ImportContainerUpdateDraft : IImportContainerUpdateDraft
    {
        public long Version { get; set; }

        public IImportResourceType ResourceType { get; set; }
    }
}
