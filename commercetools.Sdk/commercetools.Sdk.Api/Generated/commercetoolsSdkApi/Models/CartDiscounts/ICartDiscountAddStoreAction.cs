using commercetools.Sdk.Api.Models.Stores;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountAddStoreAction))]
    public partial interface ICartDiscountAddStoreAction : ICartDiscountUpdateAction
    {
        IStoreResourceIdentifier Store { get; set; }

    }
}
