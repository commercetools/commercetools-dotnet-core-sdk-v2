using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAddAssociateAction))]
    public partial interface IBusinessUnitAddAssociateAction : IBusinessUnitUpdateAction
    {
        IAssociateDraft Associate { get; set; }

    }
}
