namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitAssociateDraft : IMyBusinessUnitAssociateDraft
    {
        public long Version { get; set; }

        public IMyCustomerDraft Customer { get; set; }
    }
}
