using commercetools.Sdk.Api.Models.StagedQuotes;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StagedQuoteStateChangedMessage))]
    public partial interface IStagedQuoteStateChangedMessage : IMessage
    {
        IStagedQuoteState StagedQuoteState { get; set; }

        IStagedQuoteState OldStagedQuoteState { get; set; }

    }
}
