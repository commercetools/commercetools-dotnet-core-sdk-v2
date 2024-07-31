using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StagedQuoteSellerCommentSetMessagePayload))]
    public partial interface IStagedQuoteSellerCommentSetMessagePayload : IMessagePayload
    {
        string SellerComment { get; set; }

    }
}
