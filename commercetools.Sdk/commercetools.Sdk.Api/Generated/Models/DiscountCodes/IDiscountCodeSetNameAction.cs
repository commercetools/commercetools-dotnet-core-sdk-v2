using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetNameAction))]
    public partial interface IDiscountCodeSetNameAction : IDiscountCodeUpdateAction
    {
        ILocalizedString Name { get; set; }

    }
}
