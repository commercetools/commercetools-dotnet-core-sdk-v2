using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitAddAddressAction))]
    public partial interface IMyBusinessUnitAddAddressAction : IMyBusinessUnitUpdateAction
    {
        IBaseAddress Address { get; set; }

    }
}
