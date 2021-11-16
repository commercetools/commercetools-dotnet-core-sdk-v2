using commercetools.ImportApi.Models.Errors;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Importoperations
{
    public partial class ImportOperationStatus : IImportOperationStatus
    {
        public string OperationId { get; set;}
        
        public IImportOperationState State { get; set;}
        
        public List<IErrorObject> Errors { get; set;}
    }
}
