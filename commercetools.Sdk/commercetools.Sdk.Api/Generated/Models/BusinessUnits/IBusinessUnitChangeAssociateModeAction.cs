using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeAssociateModeAction))]
    public partial interface IBusinessUnitChangeAssociateModeAction : IBusinessUnitUpdateAction
    {
        IBusinessUnitAssociateMode AssociateMode { get; set; }

    }
}
