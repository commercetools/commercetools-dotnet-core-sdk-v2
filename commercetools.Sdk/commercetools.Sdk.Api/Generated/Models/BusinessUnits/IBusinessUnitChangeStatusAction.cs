using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeStatusAction))]
    public partial interface IBusinessUnitChangeStatusAction : IBusinessUnitUpdateAction
    {
        string Status { get; set; }

    }
}
