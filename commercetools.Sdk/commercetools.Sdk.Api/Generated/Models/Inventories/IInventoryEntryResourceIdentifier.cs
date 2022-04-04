using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntryResourceIdentifier))]
    public partial interface IInventoryEntryResourceIdentifier : IResourceIdentifier
    {
    }
}
