using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Importrequests;
using commercetools.ImportApi.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importrequests
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
