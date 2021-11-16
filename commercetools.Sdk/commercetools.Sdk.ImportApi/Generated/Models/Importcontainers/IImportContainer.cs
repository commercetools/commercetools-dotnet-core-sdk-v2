using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importcontainers
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importcontainers.ImportContainer))]
    public partial interface IImportContainer 
    {
        string Key { get; set;}
        
        IImportResourceType ResourceType { get; set;}
        
        long Version { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        DateTime LastModifiedAt { get; set;}
    }
}
