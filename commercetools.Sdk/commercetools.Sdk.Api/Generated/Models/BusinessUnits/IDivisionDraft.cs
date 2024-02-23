using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.DivisionDraft))]
    public partial interface IDivisionDraft : IBusinessUnitDraft
    {
        IBusinessUnitResourceIdentifier ParentUnit { get; set; }

        new IBusinessUnitStoreMode StoreMode { get; set; }

        new IBusinessUnitAssociateMode AssociateMode { get; set; }

    }
}
