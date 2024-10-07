using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitChangeAssociateAction))]
    public partial interface IBusinessUnitChangeAssociateAction : IBusinessUnitUpdateAction
    {
        IAssociateDraft Associate { get; set; }

    }
}
