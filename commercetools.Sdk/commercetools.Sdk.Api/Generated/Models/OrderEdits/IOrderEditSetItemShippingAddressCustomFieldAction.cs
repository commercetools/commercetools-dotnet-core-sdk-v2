using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.OrderEditSetItemShippingAddressCustomFieldAction))]
    public partial interface IOrderEditSetItemShippingAddressCustomFieldAction : IOrderEditUpdateAction
    {
        string AddressKey { get; set;}
        
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
