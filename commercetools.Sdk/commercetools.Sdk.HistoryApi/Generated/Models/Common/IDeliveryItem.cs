using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.DeliveryItem))]
    public partial interface IDeliveryItem
    {
        string Id { get; set; }

        int Quantity { get; set; }
    }
}
