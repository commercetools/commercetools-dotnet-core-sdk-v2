using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCustomerAddAddressAction))]
    public partial interface IMyCustomerAddAddressAction : IMyCustomerUpdateAction
    {
        IBaseAddress Address { get; set;}
    }
}
