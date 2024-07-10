using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetLineItemShippingDetailsAction))]
    public partial interface IOrderSetLineItemShippingDetailsAction : IOrderUpdateAction
    {
        string LineItemId { get; set; }

        string LineItemKey { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }

    }
}
