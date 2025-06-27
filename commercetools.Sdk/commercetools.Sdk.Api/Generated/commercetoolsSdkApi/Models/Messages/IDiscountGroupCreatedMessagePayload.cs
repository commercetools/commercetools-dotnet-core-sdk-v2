using commercetools.Sdk.Api.Models.DiscountGroups;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DiscountGroupCreatedMessagePayload))]
    public partial interface IDiscountGroupCreatedMessagePayload : IMessagePayload
    {
        IDiscountGroup DiscountGroup { get; set; }

    }
}
