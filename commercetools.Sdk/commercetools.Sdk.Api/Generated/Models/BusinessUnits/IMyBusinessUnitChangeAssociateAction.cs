using commercetools.Sdk.Api.Models.Me;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.MyBusinessUnitChangeAssociateAction))]
    public partial interface IMyBusinessUnitChangeAssociateAction : IMyBusinessUnitUpdateAction
    {
        IAssociateDraft Associate { get; set; }

    }
}
