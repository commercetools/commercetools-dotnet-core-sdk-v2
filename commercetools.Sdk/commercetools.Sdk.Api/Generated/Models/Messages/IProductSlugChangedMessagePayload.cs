using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductSlugChangedMessagePayload))]
    public partial interface IProductSlugChangedMessagePayload : IMessagePayload
    {
        ILocalizedString Slug { get; set; }

        ILocalizedString OldSlug { get; set; }

    }
}
