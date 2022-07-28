using commercetools.Sdk.ImportApi.Models.Errors;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importoperations
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importoperations.ImportOperationStatus))]
    public partial interface IImportOperationStatus
    {
        string OperationId { get; set; }

        IImportOperationState State { get; set; }

        List<IErrorObject> Errors { get; set; }

    }
}
