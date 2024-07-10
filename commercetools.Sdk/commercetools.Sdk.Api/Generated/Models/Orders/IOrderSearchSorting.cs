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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchSorting))]
    public partial interface IOrderSearchSorting
    {
        string Field { get; set; }

        string Language { get; set; }

        IOrderSearchSortOrder Order { get; set; }

        IOrderSearchSortMode Mode { get; set; }

        IOrderSearchQueryExpression Filter { get; set; }

    }
}
