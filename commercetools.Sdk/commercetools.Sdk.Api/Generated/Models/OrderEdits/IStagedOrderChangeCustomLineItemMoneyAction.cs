using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderChangeCustomLineItemMoneyAction))]
    public partial interface IStagedOrderChangeCustomLineItemMoneyAction : IStagedOrderUpdateAction
    {
        string CustomLineItemId { get; set; }

        IMoney Money { get; set; }

    }
}
