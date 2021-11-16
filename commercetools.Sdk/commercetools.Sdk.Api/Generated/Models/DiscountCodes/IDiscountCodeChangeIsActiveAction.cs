using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeChangeIsActiveAction))]
    public partial interface IDiscountCodeChangeIsActiveAction : IDiscountCodeUpdateAction
    {
        bool IsActive { get; set; }
    }
}
