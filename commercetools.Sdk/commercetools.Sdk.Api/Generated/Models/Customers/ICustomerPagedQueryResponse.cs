using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerPagedQueryResponse))]
    public partial interface ICustomerPagedQueryResponse 
    {
        long Limit { get; set;}
        
        long Count { get; set;}
        
        long? Total { get; set;}
        
        long Offset { get; set;}
        
        List<ICustomer> Results { get; set;}
    }
}
