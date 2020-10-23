using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerSetCustomerGroupAction))]
    public interface ICustomerSetCustomerGroupAction : ICustomerUpdateAction
    {
        ICustomerGroupResourceIdentifier CustomerGroup { get; set;}
    }
}
