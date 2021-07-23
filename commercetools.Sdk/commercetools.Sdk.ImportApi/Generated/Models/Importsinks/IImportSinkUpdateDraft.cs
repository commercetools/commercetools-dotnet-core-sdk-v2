using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importsinks
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importsinks.ImportSinkUpdateDraft))]
    public partial interface IImportSinkUpdateDraft 
    {
        long Version { get; set;}
        
        IImportResourceType ResourceType { get; set;}
    }
}