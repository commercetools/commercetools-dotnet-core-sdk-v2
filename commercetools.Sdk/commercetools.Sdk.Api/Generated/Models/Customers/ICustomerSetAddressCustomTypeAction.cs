using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerSetAddressCustomTypeAction))]
    public partial interface ICustomerSetAddressCustomTypeAction : ICustomerUpdateAction
    {
        ITypeResourceIdentifier Type { get; set;}
        
        IFieldContainer Fields { get; set;}
        
        string AddressId { get; set;}
    }
}
