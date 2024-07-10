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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderImportCustomLineItemStateAction))]
    public partial interface IOrderImportCustomLineItemStateAction : IOrderUpdateAction
    {
        string CustomLineItemId { get; set; }

        string CustomLineItemKey { get; set; }

        IList<IItemState> State { get; set; }
        IEnumerable<IItemState> StateEnumerable { set => State = value.ToList(); }


    }
}
