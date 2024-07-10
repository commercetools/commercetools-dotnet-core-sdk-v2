using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeParentUnitAction))]
    public partial interface IBusinessUnitChangeParentUnitAction : IBusinessUnitUpdateAction
    {
        IBusinessUnitResourceIdentifier ParentUnit { get; set; }

    }
}
