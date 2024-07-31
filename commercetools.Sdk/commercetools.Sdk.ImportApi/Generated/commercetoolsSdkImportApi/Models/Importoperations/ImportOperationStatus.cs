using commercetools.Sdk.ImportApi.Models.Errors;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Importoperations
{

    public partial class ImportOperationStatus : IImportOperationStatus
    {
        public string OperationId { get; set; }

        public IImportOperationState State { get; set; }

        public IList<IErrorObject> Errors { get; set; }

        public IEnumerable<IErrorObject> ErrorsEnumerable { set => Errors = value.ToList(); }
    }
}
