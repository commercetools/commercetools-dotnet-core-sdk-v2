using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyOrderFromQuoteDraft))]
    public partial interface IMyOrderFromQuoteDraft
    {
        string Id { get; set; }

        long Version { get; set; }

        bool? QuoteStateToAccepted { get; set; }

    }
}
