using commercetools.Sdk.Api.Models.StandalonePrices;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceStagedChangesAppliedMessage))]
    public partial interface IStandalonePriceStagedChangesAppliedMessage : IMessage
    {
        IStagedStandalonePrice StagedChanges { get; set; }

    }
}
