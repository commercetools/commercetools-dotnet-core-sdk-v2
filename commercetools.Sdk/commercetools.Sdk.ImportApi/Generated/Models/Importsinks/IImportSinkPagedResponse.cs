using commercetools.ImportApi.Models.Importsinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importsinks
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importsinks.ImportSinkPagedResponse))]
    public partial interface IImportSinkPagedResponse 
    {
        int Limit { get; set;}
        
        long Offset { get; set;}
        
        long Count { get; set;}
        
        List<IImportSink> Results { get; set;}
    }
}
