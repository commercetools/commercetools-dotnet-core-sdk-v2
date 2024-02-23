using commercetools.Sdk.Api.Models.States;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.QuoteStateTransitionMessagePayload))]
    public partial interface IQuoteStateTransitionMessagePayload : IMessagePayload
    {
        IStateReference State { get; set; }

        IStateReference OldState { get; set; }

        bool Force { get; set; }

    }
}
