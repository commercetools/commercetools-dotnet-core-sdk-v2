using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Inventories;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class InventoryImportRequest : IInventoryImportRequest
    {
        public IImportResourceType Type { get; set; }

        public List<IInventoryImport> Resources { get; set; }
        public InventoryImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("inventory");
        }
    }
}
