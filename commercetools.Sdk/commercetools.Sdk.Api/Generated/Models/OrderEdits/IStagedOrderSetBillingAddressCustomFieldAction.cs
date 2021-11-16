using commercetools.Api.Models.Orders;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetBillingAddressCustomFieldAction))]
    public partial interface IStagedOrderSetBillingAddressCustomFieldAction : IStagedOrderUpdateAction
    {
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
