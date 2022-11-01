using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitAssociateDraft))]
    public partial interface IMyBusinessUnitAssociateDraft
    {
        long Version { get; set; }

        IMyCustomerDraft Customer { get; set; }

    }
}
