using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerSetAddressCustomFieldAction))]
    public partial interface ICustomerSetAddressCustomFieldAction : ICustomerUpdateAction
    {
        string AddressId { get; set;}
        
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
