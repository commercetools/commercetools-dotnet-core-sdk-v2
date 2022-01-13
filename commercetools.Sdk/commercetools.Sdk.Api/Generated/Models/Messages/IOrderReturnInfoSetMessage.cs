using commercetools.Api.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderReturnInfoSetMessage))]
    public partial interface IOrderReturnInfoSetMessage : IMessage
    {
        List<IReturnInfo> ReturnInfo { get; set; }
    }
}
