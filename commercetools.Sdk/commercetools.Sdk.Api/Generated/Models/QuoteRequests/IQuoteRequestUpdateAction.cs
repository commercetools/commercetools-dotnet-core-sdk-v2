using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestUpdateAction))]
    [SubTypeDiscriminator("changeCustomer", typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestChangeCustomerAction))]
    [SubTypeDiscriminator("changeQuoteRequestState", typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestChangeQuoteRequestStateAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestSetCustomTypeAction))]
    [SubTypeDiscriminator("transitionState", typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestTransitionStateAction))]
    public partial interface IQuoteRequestUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestChangeCustomerAction ChangeCustomer(Action<commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestChangeCustomerAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestChangeCustomerAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestChangeQuoteRequestStateAction ChangeQuoteRequestState(Action<commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestChangeQuoteRequestStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestChangeQuoteRequestStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestTransitionStateAction TransitionState(Action<commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestTransitionStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestTransitionStateAction();
            init?.Invoke(t);
            return t;
        }
    }
}
