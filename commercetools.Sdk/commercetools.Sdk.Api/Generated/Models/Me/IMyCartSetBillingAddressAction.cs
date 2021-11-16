using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartSetBillingAddressAction))]
    public partial interface IMyCartSetBillingAddressAction : IMyCartUpdateAction
    {
        IBaseAddress Address { get; set; }
    }
}
