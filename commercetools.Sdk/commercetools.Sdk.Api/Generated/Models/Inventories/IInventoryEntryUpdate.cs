using commercetools.Api.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Inventories.InventoryEntryUpdate))]
    public interface IInventoryEntryUpdate 
    {
        long Version { get; set;}
        
        List<IInventoryEntryUpdateAction> Actions { get; set;}
    }
}
