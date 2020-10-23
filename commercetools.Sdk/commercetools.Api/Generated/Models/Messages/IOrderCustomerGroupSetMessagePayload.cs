using commercetools.Api.Generated.Models.CustomerGroups;
using commercetools.Api.Generated.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Messages
{
    public interface IOrderCustomerGroupSetMessagePayload : IMessagePayload
    {
        ICustomerGroupReference CustomerGroup { get; set;}
        
        ICustomerGroupReference OldCustomerGroup { get; set;}
    }
}
