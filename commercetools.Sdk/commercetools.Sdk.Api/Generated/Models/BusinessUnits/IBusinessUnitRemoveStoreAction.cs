using commercetools.Sdk.Api.Models.Stores;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitRemoveStoreAction))]
    public partial interface IBusinessUnitRemoveStoreAction : IBusinessUnitUpdateAction
    {
        IStoreResourceIdentifier Store { get; set; }

    }
}
