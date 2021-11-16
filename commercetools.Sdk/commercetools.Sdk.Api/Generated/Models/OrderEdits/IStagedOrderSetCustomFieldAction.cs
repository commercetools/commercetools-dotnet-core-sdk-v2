using commercetools.Api.Models.Orders;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetCustomFieldAction))]
    public partial interface IStagedOrderSetCustomFieldAction : IStagedOrderUpdateAction
    {
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
