using commercetools.Api.Models.OrderEdits;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.OrderEditSetItemShippingAddressCustomTypeAction))]
    public partial interface IOrderEditSetItemShippingAddressCustomTypeAction : IOrderEditUpdateAction
    {
        string AddressKey { get; set;}
        
        ITypeResourceIdentifier Type { get; set;}
        
        IFieldContainer Fields { get; set;}
    }
}
