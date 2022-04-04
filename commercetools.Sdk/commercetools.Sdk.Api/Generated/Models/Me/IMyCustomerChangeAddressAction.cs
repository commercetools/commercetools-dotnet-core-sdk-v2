using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCustomerChangeAddressAction))]
    public partial interface IMyCustomerChangeAddressAction : IMyCustomerUpdateAction
    {
        string AddressId { get; set; }

        string AddressKey { get; set; }

        IBaseAddress Address { get; set; }
    }
}
