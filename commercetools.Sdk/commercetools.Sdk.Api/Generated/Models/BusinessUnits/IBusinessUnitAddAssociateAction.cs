using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddAssociateAction))]
    public partial interface IBusinessUnitAddAssociateAction : IBusinessUnitUpdateAction
    {
        IAssociateDraft Associate { get; set; }

    }
}
