using commercetools.Sdk.ImportApi.Models.Importoperations;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ImportResponse))]
    public partial interface IImportResponse
    {
        List<IImportOperationStatus> OperationStatus { get; set; }
    }
}
