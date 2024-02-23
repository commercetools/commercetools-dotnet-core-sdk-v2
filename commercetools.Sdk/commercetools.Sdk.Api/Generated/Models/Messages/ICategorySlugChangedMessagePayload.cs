using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CategorySlugChangedMessagePayload))]
    public partial interface ICategorySlugChangedMessagePayload : IMessagePayload
    {
        ILocalizedString Slug { get; set; }

        ILocalizedString OldSlug { get; set; }

    }
}
