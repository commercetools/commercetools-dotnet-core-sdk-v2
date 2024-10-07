using commercetools.Sdk.Api.Models.StandalonePrices;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceStagedChangesRemovedMessage))]
    public partial interface IStandalonePriceStagedChangesRemovedMessage : IMessage
    {
        IStagedStandalonePrice StagedChanges { get; set; }

    }
}
