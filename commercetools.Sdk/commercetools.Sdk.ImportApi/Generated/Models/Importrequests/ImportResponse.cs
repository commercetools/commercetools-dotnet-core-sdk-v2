using commercetools.ImportApi.Models.Importoperations;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Importrequests
{
    public partial class ImportResponse : IImportResponse
    {
        public List<IImportOperationStatus> OperationStatus { get; set;}
    }
}
