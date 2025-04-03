using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetUnitTypeAction))]
    public partial interface IBusinessUnitSetUnitTypeAction : IBusinessUnitUpdateAction
    {
        IBusinessUnitType UnitType { get; set; }

        IBusinessUnitResourceIdentifier ParentUnit { get; set; }

    }
}
