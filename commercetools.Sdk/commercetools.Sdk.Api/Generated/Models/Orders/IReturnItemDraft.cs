using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.ReturnItemDraft))]
    public partial interface IReturnItemDraft
    {
        string Key { get; set; }

        long Quantity { get; set; }

        string LineItemId { get; set; }

        string CustomLineItemId { get; set; }

        string Comment { get; set; }

        IReturnShipmentState ShipmentState { get; set; }

        ICustomFieldsDraft Custom { get; set; }

    }
}
