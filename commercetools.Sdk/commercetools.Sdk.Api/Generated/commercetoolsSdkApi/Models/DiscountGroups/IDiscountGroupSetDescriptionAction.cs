using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupSetDescriptionAction))]
    public partial interface IDiscountGroupSetDescriptionAction : IDiscountGroupUpdateAction
    {
        ILocalizedString Description { get; set; }

    }
}
