using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Inventories.InventoryEntryResourceIdentifier))]
    public partial interface IInventoryEntryResourceIdentifier : IResourceIdentifier
    {
    }
}
