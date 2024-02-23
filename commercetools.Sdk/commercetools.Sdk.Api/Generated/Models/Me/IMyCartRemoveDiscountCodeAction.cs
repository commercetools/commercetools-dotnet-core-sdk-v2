using commercetools.Sdk.Api.Models.DiscountCodes;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartRemoveDiscountCodeAction))]
    public partial interface IMyCartRemoveDiscountCodeAction : IMyCartUpdateAction
    {
        IDiscountCodeReference DiscountCode { get; set; }

    }
}
