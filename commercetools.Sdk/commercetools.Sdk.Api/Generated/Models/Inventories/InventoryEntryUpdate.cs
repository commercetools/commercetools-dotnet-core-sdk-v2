using commercetools.Api.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    public  partial class InventoryEntryUpdate : IInventoryEntryUpdate
    {
        public long Version { get; set;}
        
        public List<IInventoryEntryUpdateAction> Actions { get; set;}
    }
}
