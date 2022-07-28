using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StandalonePriceExternalDiscountSetMessagePayload))]
    public partial interface IStandalonePriceExternalDiscountSetMessagePayload : IMessagePayload
    {
        IDiscountedPrice Discounted { get; set; }

    }
}
