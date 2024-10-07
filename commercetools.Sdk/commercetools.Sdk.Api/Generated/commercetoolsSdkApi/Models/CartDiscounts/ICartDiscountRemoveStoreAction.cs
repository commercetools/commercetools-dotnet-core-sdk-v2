using commercetools.Sdk.Api.Models.Stores;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountRemoveStoreAction))]
    public partial interface ICartDiscountRemoveStoreAction : ICartDiscountUpdateAction
    {
        IStoreResourceIdentifier Store { get; set; }

    }
}
