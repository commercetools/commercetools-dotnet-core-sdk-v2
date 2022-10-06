using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetContactEmailAction))]
    public partial interface IBusinessUnitSetContactEmailAction : IBusinessUnitUpdateAction
    {
        string ContactEmail { get; set; }

    }
}
