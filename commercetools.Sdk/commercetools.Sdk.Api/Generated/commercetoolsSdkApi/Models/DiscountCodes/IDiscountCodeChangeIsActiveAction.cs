using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeChangeIsActiveAction))]
    public partial interface IDiscountCodeChangeIsActiveAction : IDiscountCodeUpdateAction
    {
        bool IsActive { get; set; }

    }
}
