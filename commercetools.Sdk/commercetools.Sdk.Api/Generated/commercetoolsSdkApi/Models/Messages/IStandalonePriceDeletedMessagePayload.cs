using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceDeletedMessagePayload))]
    public partial interface IStandalonePriceDeletedMessagePayload : IMessagePayload
    {
        string Sku { get; set; }

    }
}
