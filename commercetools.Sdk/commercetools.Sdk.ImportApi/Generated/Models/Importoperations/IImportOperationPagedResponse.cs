using commercetools.ImportApi.Models.Importoperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importoperations
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importoperations.ImportOperationPagedResponse))]
    public partial interface IImportOperationPagedResponse 
    {
        int Limit { get; set;}
        
        long Offset { get; set;}
        
        long Count { get; set;}
        
        long Total { get; set;}
        
        List<IImportOperation> Results { get; set;}
    }
}
