using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importsinks
{
    public partial class ImportSinkUpdateDraft : IImportSinkUpdateDraft
    {
        public long Version { get; set;}
        
        public IImportResourceType ResourceType { get; set;}
    }
}