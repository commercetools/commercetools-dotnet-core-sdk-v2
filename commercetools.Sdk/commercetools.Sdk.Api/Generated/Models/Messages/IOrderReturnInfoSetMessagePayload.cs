using commercetools.Api.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderReturnInfoSetMessagePayload))]
    public partial interface IOrderReturnInfoSetMessagePayload : IOrderMessagePayload
    {
        List<IReturnInfo> ReturnInfo { get; set; }
    }
}
