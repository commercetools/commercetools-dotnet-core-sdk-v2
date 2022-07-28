using commercetools.Sdk.Api.Models.StagedQuotes;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StagedQuoteStateChangedMessagePayload))]
    public partial interface IStagedQuoteStateChangedMessagePayload : IMessagePayload
    {
        IStagedQuoteState StagedQuoteState { get; set; }

        IStagedQuoteState OldStagedQuoteState { get; set; }

    }
}
