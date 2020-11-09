using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCustomerChangeAddressAction))]
    public partial interface IMyCustomerChangeAddressAction : IMyCustomerUpdateAction
    {
        string AddressId { get; set;}
        
        string AddressKey { get; set;}
        
        IAddress Address { get; set;}
    }
}
