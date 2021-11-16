using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartSetShippingAddressAction))]
    public partial interface IMyCartSetShippingAddressAction : IMyCartUpdateAction
    {
        IBaseAddress Address { get; set; }
    }
}
