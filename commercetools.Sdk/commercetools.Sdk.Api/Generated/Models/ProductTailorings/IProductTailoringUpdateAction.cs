using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringUpdateAction))]
    [SubTypeDiscriminator("publish", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringPublishAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetDescriptionAction))]
    [SubTypeDiscriminator("setMetaAttributes", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaAttributesAction))]
    [SubTypeDiscriminator("setMetaDescription", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaDescriptionAction))]
    [SubTypeDiscriminator("setMetaKeywords", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaKeywordsAction))]
    [SubTypeDiscriminator("setMetaTitle", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaTitleAction))]
    [SubTypeDiscriminator("setName", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetNameAction))]
    [SubTypeDiscriminator("setSlug", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetSlugAction))]
    [SubTypeDiscriminator("unpublish", typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringUnpublishAction))]
    public partial interface IProductTailoringUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringPublishAction Publish(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringPublishAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringPublishAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetDescriptionAction SetDescription(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaAttributesAction SetMetaAttributes(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaAttributesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaAttributesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaDescriptionAction SetMetaDescription(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaKeywordsAction SetMetaKeywords(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaKeywordsAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaKeywordsAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaTitleAction SetMetaTitle(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaTitleAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetMetaTitleAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetNameAction SetName(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetSlugAction SetSlug(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetSlugAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetSlugAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringUnpublishAction Unpublish(Action<commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringUnpublishAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringUnpublishAction();
            init?.Invoke(t);
            return t;
        }
    }
}
