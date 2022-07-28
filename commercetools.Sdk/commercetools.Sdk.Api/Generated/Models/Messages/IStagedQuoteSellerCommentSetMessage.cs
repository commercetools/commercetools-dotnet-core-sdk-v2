using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StagedQuoteSellerCommentSetMessage))]
    public partial interface IStagedQuoteSellerCommentSetMessage : IMessage
    {
        string SellerComment { get; set; }

    }
}
