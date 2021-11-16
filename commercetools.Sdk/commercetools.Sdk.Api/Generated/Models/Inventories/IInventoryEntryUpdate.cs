using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Inventories.InventoryEntryUpdate))]
    public partial interface IInventoryEntryUpdate 
    {
        long Version { get; set;}
        
        List<IInventoryEntryUpdateAction> Actions { get; set;}
    }
}
