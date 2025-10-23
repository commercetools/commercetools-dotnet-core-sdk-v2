using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ReturnItem))]
    public partial interface IReturnItem
    {
        string Id { get; set; }

        string Key { get; set; }

        long Quantity { get; set; }

        string Type { get; set; }

        string Comment { get; set; }

        IReturnShipmentState ShipmentState { get; set; }

        IReturnPaymentState PaymentState { get; set; }

        ICustomFields Custom { get; set; }

        DateTime LastModifiedAt { get; set; }

        DateTime CreatedAt { get; set; }

    }
}
