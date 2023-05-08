using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.Company))]
    public partial interface ICompany : IBusinessUnit
    {
        new IBusinessUnitStoreMode StoreMode { get; set; }

        new IBusinessUnitAssociateMode AssociateMode { get; set; }

    }
}
