using commercetools.Sdk.Api.Models.States;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.QuoteStateTransitionMessage))]
    public partial interface IQuoteStateTransitionMessage : IMessage
    {
        IStateReference State { get; set; }

        IStateReference OldState { get; set; }

        bool Force { get; set; }

    }
}
