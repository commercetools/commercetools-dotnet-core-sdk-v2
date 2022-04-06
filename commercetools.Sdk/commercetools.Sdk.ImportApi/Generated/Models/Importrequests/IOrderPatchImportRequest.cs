using commercetools.Sdk.ImportApi.Models.OrderPatches;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.OrderPatchImportRequest))]
    public partial interface IOrderPatchImportRequest : IImportRequest
    {
        List<IOrderPatchImport> Patches { get; set; }
    }
}
