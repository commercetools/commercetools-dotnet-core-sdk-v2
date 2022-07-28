using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddDiscountCodeAction))]
    public partial interface IStagedOrderAddDiscountCodeAction : IStagedOrderUpdateAction
    {
        string Code { get; set; }

    }
}
