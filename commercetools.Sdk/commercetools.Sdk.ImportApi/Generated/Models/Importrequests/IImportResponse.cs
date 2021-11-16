using commercetools.ImportApi.Models.Importoperations;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importrequests.ImportResponse))]
    public partial interface IImportResponse
    {
        List<IImportOperationStatus> OperationStatus { get; set; }
    }
}
