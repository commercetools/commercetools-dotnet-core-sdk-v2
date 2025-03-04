using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.BestDeal))]
    public partial interface IBestDeal : IDiscountTypeCombination
    {
        string ChosenDiscountType { get; set; }

    }
}
