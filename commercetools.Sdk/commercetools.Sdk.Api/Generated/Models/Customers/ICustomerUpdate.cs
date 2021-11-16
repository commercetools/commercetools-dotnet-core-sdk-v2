using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerUpdate))]
    public partial interface ICustomerUpdate 
    {
        long Version { get; set;}
        
        List<ICustomerUpdateAction> Actions { get; set;}
    }
}
