using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Quotes
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Quotes.QuoteUpdateAction))]
    [SubTypeDiscriminator("changeCustomer", typeof(commercetools.Sdk.Api.Models.Quotes.QuoteChangeCustomerAction))]
    [SubTypeDiscriminator("changeQuoteState", typeof(commercetools.Sdk.Api.Models.Quotes.QuoteChangeQuoteStateAction))]
    [SubTypeDiscriminator("requestQuoteRenegotiation", typeof(commercetools.Sdk.Api.Models.Quotes.QuoteRequestQuoteRenegotiationAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.Quotes.QuoteSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.Quotes.QuoteSetCustomTypeAction))]
    [SubTypeDiscriminator("transitionState", typeof(commercetools.Sdk.Api.Models.Quotes.QuoteTransitionStateAction))]
    public partial interface IQuoteUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.Quotes.QuoteChangeCustomerAction ChangeCustomer(Action<commercetools.Sdk.Api.Models.Quotes.QuoteChangeCustomerAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Quotes.QuoteChangeCustomerAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Quotes.QuoteChangeQuoteStateAction ChangeQuoteState(Action<commercetools.Sdk.Api.Models.Quotes.QuoteChangeQuoteStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Quotes.QuoteChangeQuoteStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Quotes.QuoteRequestQuoteRenegotiationAction RequestQuoteRenegotiation(Action<commercetools.Sdk.Api.Models.Quotes.QuoteRequestQuoteRenegotiationAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Quotes.QuoteRequestQuoteRenegotiationAction();
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
        static commercetools.Sdk.Api.Models.Quotes.QuoteTransitionStateAction TransitionState(Action<commercetools.Sdk.Api.Models.Quotes.QuoteTransitionStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Quotes.QuoteTransitionStateAction();
            init?.Invoke(t);
            return t;
        }
    }
}
