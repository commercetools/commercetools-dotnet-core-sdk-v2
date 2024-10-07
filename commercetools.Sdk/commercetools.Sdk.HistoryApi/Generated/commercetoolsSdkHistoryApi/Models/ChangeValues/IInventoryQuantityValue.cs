using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.InventoryQuantityValue))]
    public partial interface IInventoryQuantityValue
    {
        int QuantityOnStock { get; set; }

        int AvailableQuantity { get; set; }

    }
}
