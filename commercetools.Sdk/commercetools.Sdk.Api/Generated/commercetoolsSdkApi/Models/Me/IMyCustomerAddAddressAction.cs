using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCustomerAddAddressAction))]
    public partial interface IMyCustomerAddAddressAction : IMyCustomerUpdateAction
    {
        IBaseAddress Address { get; set; }

    }
}
