using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Inventories;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class InventoryImportRequest : IInventoryImportRequest
    {
        public IImportResourceType Type { get; set; }

        public IList<IInventoryImport> Resources { get; set; }

        public IEnumerable<IInventoryImport> ResourcesEnumerable { set => Resources = value.ToList(); }
        public InventoryImportRequest()
        {
            this.Type = IImportResourceType.FindEnum("inventory");
        }
    }
}
