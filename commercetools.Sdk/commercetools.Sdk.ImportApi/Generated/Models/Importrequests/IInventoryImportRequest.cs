using commercetools.Sdk.ImportApi.Models.Inventories;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.InventoryImportRequest))]
    public partial interface IInventoryImportRequest : IImportRequest
    {
        IList<IInventoryImport> Resources { get; set; }
        IEnumerable<IInventoryImport> ResourcesEnumerable { set => Resources = value.ToList(); }


    }
}
