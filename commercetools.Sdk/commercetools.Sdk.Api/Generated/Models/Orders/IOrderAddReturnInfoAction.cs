using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

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
