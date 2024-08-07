using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetDescriptionAction))]
    public partial interface IDiscountCodeSetDescriptionAction : IDiscountCodeUpdateAction
    {
        ILocalizedString Description { get; set; }

    }
}
