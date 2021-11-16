using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartUpdateItemShippingAddressAction))]
    public partial interface IMyCartUpdateItemShippingAddressAction : IMyCartUpdateAction
    {
        IBaseAddress Address { get; set;}
    }
}
