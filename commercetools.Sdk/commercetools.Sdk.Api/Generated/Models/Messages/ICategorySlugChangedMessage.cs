using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CategorySlugChangedMessage))]
    public partial interface ICategorySlugChangedMessage : IMessage
    {
        ILocalizedString Slug { get; set; }

        ILocalizedString OldSlug { get; set; }

    }
}
