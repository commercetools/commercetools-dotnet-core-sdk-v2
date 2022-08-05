using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestDraft))]
    public partial interface IQuoteRequestDraft
    {
        ICartResourceIdentifier Cart { get; set; }

        long CartVersion { get; set; }

        string Key { get; set; }

        string Comment { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IStateReference State { get; set; }

    }
}
