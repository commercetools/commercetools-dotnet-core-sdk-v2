using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartAddItemShippingAddressAction))]
    public partial interface IMyCartAddItemShippingAddressAction : IMyCartUpdateAction
    {
        IBaseAddress Address { get; set; }

    }
}
