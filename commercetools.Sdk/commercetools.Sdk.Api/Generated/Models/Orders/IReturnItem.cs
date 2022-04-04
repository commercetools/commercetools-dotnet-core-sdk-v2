using commercetools.Sdk.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Orders.ReturnItem))]
    [SubTypeDiscriminator("CustomLineItemReturnItem", typeof(commercetools.Sdk.Api.Models.Orders.CustomLineItemReturnItem))]
    [SubTypeDiscriminator("LineItemReturnItem", typeof(commercetools.Sdk.Api.Models.Orders.LineItemReturnItem))]
    public partial interface IReturnItem
    {
        string Id { get; set; }

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
