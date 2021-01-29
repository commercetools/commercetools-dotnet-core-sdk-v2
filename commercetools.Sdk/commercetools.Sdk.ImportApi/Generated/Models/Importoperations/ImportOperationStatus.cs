using commercetools.ImportApi.Models.Errors;
using commercetools.ImportApi.Models.Importoperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importoperations
{
    public partial class ImportOperationStatus : IImportOperationStatus
    {
        public string OperationId { get; set;}
        
        public IImportOperationState State { get; set;}
        
        public List<IErrorObject> Errors { get; set;}
    }
}
