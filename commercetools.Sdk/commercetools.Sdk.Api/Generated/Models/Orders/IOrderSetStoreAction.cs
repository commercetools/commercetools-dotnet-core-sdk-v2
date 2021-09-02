using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetStoreAction))]
    public partial interface IOrderSetStoreAction : IOrderUpdateAction
    {
        IStoreResourceIdentifier Store { get; set; }
    }
}
