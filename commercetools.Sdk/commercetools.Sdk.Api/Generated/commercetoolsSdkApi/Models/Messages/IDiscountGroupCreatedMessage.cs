using commercetools.Sdk.Api.Models.DiscountGroups;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DiscountGroupCreatedMessage))]
    public partial interface IDiscountGroupCreatedMessage : IMessage
    {
        IDiscountGroup DiscountGroup { get; set; }

    }
}
