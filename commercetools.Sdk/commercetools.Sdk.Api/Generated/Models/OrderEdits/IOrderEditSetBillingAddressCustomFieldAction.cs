using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.OrderEditSetBillingAddressCustomFieldAction))]
    public partial interface IOrderEditSetBillingAddressCustomFieldAction : IOrderEditUpdateAction
    {
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
