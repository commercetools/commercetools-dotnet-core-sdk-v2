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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.CustomLineItemReturnItem))]
    public partial interface ICustomLineItemReturnItem : IReturnItem
    {
        new string Key { get; set; }

        string CustomLineItemId { get; set; }

        new long Quantity { get; set; }

    }
}
