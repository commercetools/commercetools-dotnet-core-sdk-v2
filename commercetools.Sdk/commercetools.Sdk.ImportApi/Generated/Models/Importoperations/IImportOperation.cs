using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importoperations
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importoperations.ImportOperation))]
    public partial interface IImportOperation 
    {
        long Version { get; set;}
        
        string ImportSinkKey { get; set;}
        
        string ResourceKey { get; set;}
        
        string Id { get; set;}
        
        IProcessingState State { get; set;}
        
        long? ResourceVersion { get; set;}
        
        List<IErrorObject> Errors { get; set;}
        
        List<IKeyReference> UnresolvedReferences { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        DateTime LastModifiedAt { get; set;}
        
        DateTime ExpiresAt { get; set;}
    }
}
