using commercetools.Sdk.Api.Models.QuoteRequests;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StagedQuotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteDraft))]
    public partial interface IStagedQuoteDraft
    {
        IQuoteRequestResourceIdentifier QuoteRequest { get; set; }

        long QuoteRequestVersion { get; set; }

        bool? QuoteRequestStateToAccepted { get; set; }

        string Key { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IStateReference State { get; set; }

    }
}
