using commercetools.Sdk.ImportApi.Models.Importoperations;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class ImportResponse : IImportResponse
    {
        public IList<IImportOperationStatus> OperationStatus { get; set; }
        public IEnumerable<IImportOperationStatus> OperationStatusEnumerable { set => OperationStatus = value.ToList(); }

    }
}
