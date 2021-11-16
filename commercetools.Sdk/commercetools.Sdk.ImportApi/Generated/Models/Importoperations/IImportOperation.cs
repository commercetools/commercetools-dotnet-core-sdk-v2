using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Errors;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importoperations
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importoperations.ImportOperation))]
    public partial interface IImportOperation 
    {
        long Version { get; set;}
        
        string ImportContainerKey { get; set;}
        
        string ResourceKey { get; set;}
        
        string Id { get; set;}
        
        IProcessingState State { get; set;}
        
        long? ResourceVersion { get; set;}
        
        List<IErrorObject> Errors { get; set;}
        
        List<IUnresolvedReferences> UnresolvedReferences { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        DateTime LastModifiedAt { get; set;}
        
        DateTime ExpiresAt { get; set;}
    }
}
