using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.CustomerGroups;
using commercetools.Api.Generated.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Messages
{
    public interface IOrderCustomerGroupSetMessage : IMessage
    {
        ICustomerGroupReference CustomerGroup { get; set;}
        
        ICustomerGroupReference OldCustomerGroup { get; set;}
    }
}
