using commercetools.Sdk.Api.Models.States;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StagedQuotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteTransitionStateAction))]
    public partial interface IStagedQuoteTransitionStateAction : IStagedQuoteUpdateAction
    {
        IStateResourceIdentifier State { get; set; }

        bool? Force { get; set; }

    }
}
