using commercetools.Api.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetReturnInfoAction))]
    public partial interface IStagedOrderSetReturnInfoAction : IStagedOrderUpdateAction
    {
        List<IReturnInfoDraft> Items { get; set;}
    }
}
