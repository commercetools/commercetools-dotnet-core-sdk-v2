using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DiscountGroupIsActiveSetMessagePayload))]
    public partial interface IDiscountGroupIsActiveSetMessagePayload : IMessagePayload
    {
        bool? IsActive { get; set; }

        bool? OldIsActive { get; set; }

    }
}
