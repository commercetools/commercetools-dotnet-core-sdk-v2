using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importcontainers
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importcontainers.ImportContainerDraft))]
    public partial interface IImportContainerDraft
    {
        string Key { get; set; }

        IImportResourceType ResourceType { get; set; }
    }
}
