using commercetools.ImportApi.Models.Importoperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importoperations
{
    public partial class ImportOperationPagedResponse : IImportOperationPagedResponse
    {
        public int Limit { get; set;}
        
        public long Offset { get; set;}
        
        public long Count { get; set;}
        
        public List<IImportOperation> Results { get; set;}
    }
}
