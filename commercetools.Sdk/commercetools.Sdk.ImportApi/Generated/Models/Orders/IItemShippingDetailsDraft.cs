using commercetools.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.ItemShippingDetailsDraft))]
    public partial interface IItemShippingDetailsDraft 
    {
        List<IItemShippingTarget> Targets { get; set;}
    }
}
