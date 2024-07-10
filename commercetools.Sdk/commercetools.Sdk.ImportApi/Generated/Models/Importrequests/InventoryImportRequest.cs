using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using commercetools.Sdk.ImportApi.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
