using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceTierRemovedMessage))]
    public partial interface IStandalonePriceTierRemovedMessage : IMessage
    {
        IPriceTier RemovedTier { get; set; }

    }
}
