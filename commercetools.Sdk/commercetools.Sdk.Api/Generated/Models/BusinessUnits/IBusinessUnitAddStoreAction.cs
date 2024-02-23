using commercetools.Sdk.Api.Models.Stores;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddStoreAction))]
    public partial interface IBusinessUnitAddStoreAction : IBusinessUnitUpdateAction
    {
        IStoreResourceIdentifier Store { get; set; }

    }
}
