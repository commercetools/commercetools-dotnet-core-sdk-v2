using commercetools.Sdk.Api.Models.DiscountCodes;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DiscountCodeCreatedMessage))]
    public partial interface IDiscountCodeCreatedMessage : IMessage
    {
        IDiscountCode DiscountCode { get; set; }

    }
}
