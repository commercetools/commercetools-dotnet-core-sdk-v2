using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDirectDiscountsIgnoreCartDiscountsAction))]
    public partial interface IStagedOrderSetDirectDiscountsIgnoreCartDiscountsAction : IStagedOrderUpdateAction
    {
        bool? DirectDiscountsIgnoreCartDiscounts { get; set; }

    }
}
