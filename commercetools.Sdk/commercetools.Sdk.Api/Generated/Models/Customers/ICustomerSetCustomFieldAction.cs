using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerSetCustomFieldAction))]
    public partial interface ICustomerSetCustomFieldAction : ICustomerUpdateAction
    {
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
