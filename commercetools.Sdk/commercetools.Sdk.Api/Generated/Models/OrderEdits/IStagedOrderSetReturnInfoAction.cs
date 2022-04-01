using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnInfoAction))]
    public partial interface IStagedOrderSetReturnInfoAction : IStagedOrderUpdateAction
    {
        List<IReturnInfoDraft> Items { get; set; }
    }
}
