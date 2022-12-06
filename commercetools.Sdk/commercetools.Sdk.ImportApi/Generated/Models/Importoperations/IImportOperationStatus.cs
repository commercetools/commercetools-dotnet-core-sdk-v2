using commercetools.Sdk.ImportApi.Models.Errors;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importoperations
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importoperations.ImportOperationStatus))]
    public partial interface IImportOperationStatus
    {
        string OperationId { get; set; }

        IImportOperationState State { get; set; }

        IList<IErrorObject> Errors { get; set; }
        IEnumerable<IErrorObject> ErrorsEnumerable { set => Errors = value.ToList(); }


    }
}
