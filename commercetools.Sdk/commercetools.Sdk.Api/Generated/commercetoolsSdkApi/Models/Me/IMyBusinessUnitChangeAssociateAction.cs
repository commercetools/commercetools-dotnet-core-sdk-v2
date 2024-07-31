using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitChangeAssociateAction))]
    public partial interface IMyBusinessUnitChangeAssociateAction : IMyBusinessUnitUpdateAction
    {
        IAssociateDraft Associate { get; set; }

    }
}
