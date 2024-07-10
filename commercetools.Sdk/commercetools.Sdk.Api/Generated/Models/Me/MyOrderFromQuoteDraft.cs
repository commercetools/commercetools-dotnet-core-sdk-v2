namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyOrderFromQuoteDraft : IMyOrderFromQuoteDraft
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public bool? QuoteStateToAccepted { get; set; }
    }
}
