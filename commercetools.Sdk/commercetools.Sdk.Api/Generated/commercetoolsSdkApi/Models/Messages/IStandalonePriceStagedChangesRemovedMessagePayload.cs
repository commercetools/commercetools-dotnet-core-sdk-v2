using commercetools.Sdk.Api.Models.StandalonePrices;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceStagedChangesRemovedMessagePayload))]
    public partial interface IStandalonePriceStagedChangesRemovedMessagePayload : IMessagePayload
    {
        IStagedStandalonePrice StagedChanges { get; set; }

    }
}
