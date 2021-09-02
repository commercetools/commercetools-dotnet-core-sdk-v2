using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderCustomerGroupSetMessagePayload))]
    public partial interface IOrderCustomerGroupSetMessagePayload : IMessagePayload
    {
        ICustomerGroupReference CustomerGroup { get; set; }

        ICustomerGroupReference OldCustomerGroup { get; set; }
    }
}
