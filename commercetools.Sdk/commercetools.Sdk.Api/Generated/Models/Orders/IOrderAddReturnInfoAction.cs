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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderAddReturnInfoAction))]
    public partial interface IOrderAddReturnInfoAction : IOrderUpdateAction
    {
        string ReturnTrackingId { get; set; }

        IList<IReturnItemDraft> Items { get; set; }
        IEnumerable<IReturnItemDraft> ItemsEnumerable { set => Items = value.ToList(); }


        DateTime? ReturnDate { get; set; }

    }
}
