using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.DeliveryItem))]
    public partial interface IDeliveryItem
    {
        string Id { get; set; }

        int Quantity { get; set; }

    }
}
