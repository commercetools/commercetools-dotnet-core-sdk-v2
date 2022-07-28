using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntryReference))]
    public partial interface IInventoryEntryReference : IReference
    {
        IInventoryEntry Obj { get; set; }

        new string Id { get; set; }

    }
}
