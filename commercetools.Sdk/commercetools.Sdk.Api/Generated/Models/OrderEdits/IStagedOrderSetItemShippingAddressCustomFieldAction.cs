using commercetools.Api.Models.Orders;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetItemShippingAddressCustomFieldAction))]
    public partial interface IStagedOrderSetItemShippingAddressCustomFieldAction : IStagedOrderUpdateAction
    {
        string AddressKey { get; set;}
        
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
