using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitKeyReference))]
    public partial interface IBusinessUnitKeyReference : IKeyReference
    {
        new string Key { get; set; }

    }
}
