using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ReturnItem))]
    public partial interface IReturnItem
    {
        string Id { get; set; }

        int Quantity { get; set; }

        string Type { get; set; }

        string Comment { get; set; }

        IReturnShipmentState ShipmentState { get; set; }

        IReturnPaymentState PaymentState { get; set; }

        string LastModifiedAt { get; set; }

        string CreatedAt { get; set; }

    }
}
