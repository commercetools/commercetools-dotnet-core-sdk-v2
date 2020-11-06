using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetBillingAddressAction))]
    public partial interface IStagedOrderSetBillingAddressAction : IStagedOrderUpdateAction
    {
        IAddress Address { get; set;}
    }
}
