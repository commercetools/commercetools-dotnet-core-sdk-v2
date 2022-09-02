using commercetools.Sdk.Api.Models.States;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StagedQuoteStateTransitionMessagePayload))]
    public partial interface IStagedQuoteStateTransitionMessagePayload : IMessagePayload
    {
        IStateReference State { get; set; }

        IStateReference OldState { get; set; }

        bool Force { get; set; }

    }
}
