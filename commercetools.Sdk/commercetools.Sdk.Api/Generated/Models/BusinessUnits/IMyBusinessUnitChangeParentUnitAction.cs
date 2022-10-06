using commercetools.Sdk.Api.Models.Me;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.MyBusinessUnitChangeParentUnitAction))]
    public partial interface IMyBusinessUnitChangeParentUnitAction : IMyBusinessUnitUpdateAction
    {
        IBusinessUnitResourceIdentifier ParentUnit { get; set; }

    }
}
