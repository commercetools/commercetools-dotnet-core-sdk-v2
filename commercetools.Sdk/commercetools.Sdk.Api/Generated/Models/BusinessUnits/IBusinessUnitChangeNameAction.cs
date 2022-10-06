using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeNameAction))]
    public partial interface IBusinessUnitChangeNameAction : IBusinessUnitUpdateAction
    {
        string Name { get; set; }

    }
}
