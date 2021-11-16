using commercetools.ImportApi.Models.Inventories;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importrequests.InventoryImportRequest))]
    public partial interface IInventoryImportRequest : IImportRequest
    {
        List<IInventoryImport> Resources { get; set;}
    }
}
