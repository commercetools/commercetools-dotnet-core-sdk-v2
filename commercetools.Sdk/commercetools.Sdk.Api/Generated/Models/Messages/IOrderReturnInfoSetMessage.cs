using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderReturnInfoSetMessage))]
    public partial interface IOrderReturnInfoSetMessage : IMessage
    {
        List<IReturnInfo> ReturnInfo { get; set;}
    }
}
