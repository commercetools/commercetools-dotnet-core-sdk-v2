using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderReturnInfoSetMessage))]
    public partial interface IOrderReturnInfoSetMessage : IOrderMessage
    {
        List<IReturnInfo> ReturnInfo { get; set; }

    }
}
