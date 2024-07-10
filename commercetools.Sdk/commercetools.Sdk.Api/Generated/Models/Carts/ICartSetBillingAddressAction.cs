using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetBillingAddressAction))]
    public partial interface ICartSetBillingAddressAction : ICartUpdateAction
    {
        IBaseAddress Address { get; set; }

    }
}
