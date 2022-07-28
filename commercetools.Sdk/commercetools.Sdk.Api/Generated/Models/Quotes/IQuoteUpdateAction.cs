using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Quotes
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Quotes.QuoteUpdateAction))]
    [SubTypeDiscriminator("changeQuoteState", typeof(commercetools.Sdk.Api.Models.Quotes.QuoteChangeQuoteStateAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.Quotes.QuoteSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.Quotes.QuoteSetCustomTypeAction))]
    public partial interface IQuoteUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.Quotes.QuoteChangeQuoteStateAction ChangeQuoteState(Action<commercetools.Sdk.Api.Models.Quotes.QuoteChangeQuoteStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Quotes.QuoteChangeQuoteStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Quotes.QuoteSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.Quotes.QuoteSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Quotes.QuoteSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Quotes.QuoteSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.Quotes.QuoteSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Quotes.QuoteSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
    }
}
