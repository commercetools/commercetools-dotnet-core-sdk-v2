using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderRemoveDiscountCodeAction))]
    public partial interface IStagedOrderRemoveDiscountCodeAction : IStagedOrderUpdateAction
    {
        IDiscountCodeReference DiscountCode { get; set;}
    }
}
