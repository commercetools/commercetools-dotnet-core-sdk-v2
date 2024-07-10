using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddDiscountCodeAction))]
    public partial interface IStagedOrderAddDiscountCodeAction : IStagedOrderUpdateAction
    {
        string Code { get; set; }

    }
}
