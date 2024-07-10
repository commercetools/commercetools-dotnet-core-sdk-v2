using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceTierRemovedMessagePayload))]
    public partial interface IStandalonePriceTierRemovedMessagePayload : IMessagePayload
    {
        IPriceTier RemovedTier { get; set; }

    }
}
