using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Inventories.InventoryEntrySetExpectedDeliveryAction))]
    public partial interface IInventoryEntrySetExpectedDeliveryAction : IInventoryEntryUpdateAction
    {
        DateTime? ExpectedDelivery { get; set;}
    }
}
