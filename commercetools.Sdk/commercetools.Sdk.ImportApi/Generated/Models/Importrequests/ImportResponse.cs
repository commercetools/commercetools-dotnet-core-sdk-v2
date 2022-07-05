using commercetools.Sdk.ImportApi.Models.Importoperations;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class ImportResponse : IImportResponse
    {
        public List<IImportOperationStatus> OperationStatus { get; set; }
    }
}
