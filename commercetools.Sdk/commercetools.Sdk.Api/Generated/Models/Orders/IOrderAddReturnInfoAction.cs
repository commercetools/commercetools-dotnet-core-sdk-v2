using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderAddReturnInfoAction))]
    public partial interface IOrderAddReturnInfoAction : IOrderUpdateAction
    {
        string ReturnTrackingId { get; set; }

        List<IReturnItemDraft> Items { get; set; }

        DateTime? ReturnDate { get; set; }
    }
}
