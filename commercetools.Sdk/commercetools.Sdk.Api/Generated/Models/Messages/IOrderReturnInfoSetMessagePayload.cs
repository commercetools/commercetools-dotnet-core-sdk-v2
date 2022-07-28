using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderReturnInfoSetMessagePayload))]
    public partial interface IOrderReturnInfoSetMessagePayload : IOrderMessagePayload
    {
        List<IReturnInfo> ReturnInfo { get; set; }

    }
}
