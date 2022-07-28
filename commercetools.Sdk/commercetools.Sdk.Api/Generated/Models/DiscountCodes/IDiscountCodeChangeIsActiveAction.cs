using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeChangeIsActiveAction))]
    public partial interface IDiscountCodeChangeIsActiveAction : IDiscountCodeUpdateAction
    {
        bool IsActive { get; set; }

    }
}
