using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderCustomerSetMessage))]
    public interface IOrderCustomerSetMessage : IMessage
    {
        ICustomerReference Customer { get; set;}
        
        ICustomerGroupReference CustomerGroup { get; set;}
        
        ICustomerReference OldCustomer { get; set;}
        
        ICustomerGroupReference OldCustomerGroup { get; set;}
    }
}
