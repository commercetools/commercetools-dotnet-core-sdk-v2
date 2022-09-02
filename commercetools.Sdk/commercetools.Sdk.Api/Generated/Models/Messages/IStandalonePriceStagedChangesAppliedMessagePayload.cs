using commercetools.Sdk.Api.Models.StandalonePrices;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceStagedChangesAppliedMessagePayload))]
    public partial interface IStandalonePriceStagedChangesAppliedMessagePayload : IMessagePayload
    {
        IStagedStandalonePrice StagedChanges { get; set; }

    }
}
