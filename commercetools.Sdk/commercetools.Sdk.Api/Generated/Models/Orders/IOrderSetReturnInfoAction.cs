using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetReturnInfoAction))]
    public partial interface IOrderSetReturnInfoAction : IOrderUpdateAction
    {
        List<IReturnInfoDraft> Items { get; set; }

    }
}
