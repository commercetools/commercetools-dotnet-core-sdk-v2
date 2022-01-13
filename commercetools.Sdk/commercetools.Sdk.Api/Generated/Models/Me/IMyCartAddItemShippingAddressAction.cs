using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartAddItemShippingAddressAction))]
    public partial interface IMyCartAddItemShippingAddressAction : IMyCartUpdateAction
    {
        IBaseAddress Address { get; set; }
    }
}
