using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductSlugChangedMessagePayload))]
    public partial interface IProductSlugChangedMessagePayload : IMessagePayload
    {
        ILocalizedString Slug { get; set;}
        
        ILocalizedString OldSlug { get; set;}
    }
}
