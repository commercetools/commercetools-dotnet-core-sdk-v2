using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetExpectedDeliveryAction))]
    public partial interface IInventoryEntrySetExpectedDeliveryAction : IInventoryEntryUpdateAction
    {
        DateTime? ExpectedDelivery { get; set; }

    }
}
