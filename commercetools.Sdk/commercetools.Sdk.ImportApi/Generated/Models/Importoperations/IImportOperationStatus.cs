using commercetools.ImportApi.Models.Errors;
using commercetools.ImportApi.Models.Importoperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importoperations
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importoperations.ImportOperationStatus))]
    public partial interface IImportOperationStatus
    {
        string OperationId { get; set; }

        IImportOperationState State { get; set; }

        List<IErrorObject> Errors { get; set; }
    }
}
