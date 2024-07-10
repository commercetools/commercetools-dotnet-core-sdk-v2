using commercetools.Sdk.Api.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Inventories
{

    public partial class InventoryEntryUpdate : IInventoryEntryUpdate
    {
        public long Version { get; set; }

        public IList<IInventoryEntryUpdateAction> Actions { get; set; }
        public IEnumerable<IInventoryEntryUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
