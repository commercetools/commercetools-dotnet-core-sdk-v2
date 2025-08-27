using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DiscountGroupIsActiveSetMessage))]
    public partial interface IDiscountGroupIsActiveSetMessage : IMessage
    {
        bool? IsActive { get; set; }

        bool? OldIsActive { get; set; }

    }
}
