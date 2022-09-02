using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ReturnInfoSetMessage))]
    public partial interface IReturnInfoSetMessage : IOrderMessage
    {
        List<IReturnInfo> ReturnInfo { get; set; }

    }
}
