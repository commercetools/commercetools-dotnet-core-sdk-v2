using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.Division))]
    public partial interface IDivision : IBusinessUnit
    {
        new IBusinessUnitKeyReference ParentUnit { get; set; }

        new IBusinessUnitStoreMode StoreMode { get; set; }

    }
}
