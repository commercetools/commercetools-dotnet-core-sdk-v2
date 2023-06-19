using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceDiscountSetMessage))]
    public partial interface IStandalonePriceDiscountSetMessage : IMessage
    {
        IDiscountedPrice Discounted { get; set; }

    }
}
