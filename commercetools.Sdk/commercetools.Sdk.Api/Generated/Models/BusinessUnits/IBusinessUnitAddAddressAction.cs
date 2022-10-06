using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddAddressAction))]
    public partial interface IBusinessUnitAddAddressAction : IBusinessUnitUpdateAction
    {
        IBaseAddress Address { get; set; }

    }
}
