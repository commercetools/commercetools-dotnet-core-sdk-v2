using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyDivisionDraft))]
    public partial interface IMyDivisionDraft : IMyBusinessUnitDraft
    {
        IBusinessUnitResourceIdentifier ParentUnit { get; set; }

    }
}
