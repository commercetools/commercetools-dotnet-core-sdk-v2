using commercetools.Sdk.Api.Models.DiscountCodes;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderRemoveDiscountCodeAction))]
    public partial interface IStagedOrderRemoveDiscountCodeAction : IStagedOrderUpdateAction
    {
        IDiscountCodeReference DiscountCode { get; set; }

    }
}
