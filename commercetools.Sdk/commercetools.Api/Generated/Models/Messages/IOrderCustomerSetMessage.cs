using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.CustomerGroups;
using commercetools.Api.Generated.Models.Customers;
using commercetools.Api.Generated.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Messages
{
    public interface IOrderCustomerSetMessage : IMessage
    {
        ICustomerReference Customer { get; set;}
        
        ICustomerGroupReference CustomerGroup { get; set;}
        
        ICustomerReference OldCustomer { get; set;}
        
        ICustomerGroupReference OldCustomerGroup { get; set;}
    }
}
