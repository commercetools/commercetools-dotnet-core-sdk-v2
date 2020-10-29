using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderUpdateItemShippingAddressAction))]
    public interface IStagedOrderUpdateItemShippingAddressAction : IStagedOrderUpdateAction
    {
        IAddress Address { get; set;}
    }
}
