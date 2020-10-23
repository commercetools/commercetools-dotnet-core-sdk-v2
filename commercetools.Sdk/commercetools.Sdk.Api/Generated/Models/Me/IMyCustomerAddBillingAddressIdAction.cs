using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCustomerAddBillingAddressIdAction))]
    public interface IMyCustomerAddBillingAddressIdAction : IMyCustomerUpdateAction
    {
        string AddressId { get; set;}
    }
}
