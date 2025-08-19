using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.BusinessUnits.CompanyBusinessUnitImport))]
    public partial interface ICompanyBusinessUnitImport : IBusinessUnitImport
    {
        IBusinessUnitStoreMode StoreMode { get; set; }

    }
}
