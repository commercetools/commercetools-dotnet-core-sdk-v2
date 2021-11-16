using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeSetNameAction))]
    public partial interface IDiscountCodeSetNameAction : IDiscountCodeUpdateAction
    {
        ILocalizedString Name { get; set; }
    }
}
