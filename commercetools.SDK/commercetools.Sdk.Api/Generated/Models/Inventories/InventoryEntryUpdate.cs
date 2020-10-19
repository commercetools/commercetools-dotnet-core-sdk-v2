using commercetools.Api.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Inventories
{
    public partial class InventoryEntryUpdate 
    {
        public long Version { get; set;}
        
        public List<InventoryEntryUpdateAction> Actions { get; set;}
    }
}
