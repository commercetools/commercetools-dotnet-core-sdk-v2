using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    public partial class InventoryEntryUpdateAction : IInventoryEntryUpdateAction
    {
        public string Action { get; set; }
    }
}
