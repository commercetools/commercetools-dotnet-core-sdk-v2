using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.CustomerCreatedMessagePayload))]
    public interface ICustomerCreatedMessagePayload : IMessagePayload
    {
        ICustomer Customer { get; set;}
    }
}
