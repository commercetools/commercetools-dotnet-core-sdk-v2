using commercetools.Sdk.Api.Models.DiscountGroups;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetDiscountGroupAction))]
    public partial interface ICartDiscountSetDiscountGroupAction : ICartDiscountUpdateAction
    {
        IDiscountGroupResourceIdentifier DiscountGroup { get; set; }

        string SortOrder { get; set; }

    }
}
