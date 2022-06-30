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
    }
}
