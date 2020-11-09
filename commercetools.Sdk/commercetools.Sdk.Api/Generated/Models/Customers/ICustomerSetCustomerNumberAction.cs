using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerSetCustomerNumberAction))]
    public partial interface ICustomerSetCustomerNumberAction : ICustomerUpdateAction
    {
        string CustomerNumber { get; set;}
    }
}
