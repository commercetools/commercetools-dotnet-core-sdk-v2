using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.StagedQuotes
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteUpdateAction))]
    [SubTypeDiscriminator("changeStagedQuoteState", typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteChangeStagedQuoteStateAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteSetCustomTypeAction))]
    [SubTypeDiscriminator("setSellerComment", typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteSetSellerCommentAction))]
    [SubTypeDiscriminator("setValidTo", typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteSetValidToAction))]
    public partial interface IStagedQuoteUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteChangeStagedQuoteStateAction ChangeStagedQuoteState(Action<commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteChangeStagedQuoteStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteChangeStagedQuoteStateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteSetSellerCommentAction SetSellerComment(Action<commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteSetSellerCommentAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteSetSellerCommentAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteSetValidToAction SetValidTo(Action<commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteSetValidToAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteSetValidToAction();
            init?.Invoke(t);
            return t;
        }
    }
}
