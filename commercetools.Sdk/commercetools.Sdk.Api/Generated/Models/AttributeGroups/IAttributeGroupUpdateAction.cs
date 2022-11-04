using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupUpdateAction))]
    [SubTypeDiscriminator("addAttribute", typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupAddAttributeAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupChangeNameAction))]
    [SubTypeDiscriminator("removeAttribute", typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupRemoveAttributeAction))]
    [SubTypeDiscriminator("setAttributes", typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupSetAttributesAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupSetDescriptionAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupSetKeyAction))]
    public partial interface IAttributeGroupUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupAddAttributeAction AddAttribute(Action<commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupAddAttributeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupAddAttributeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupChangeNameAction ChangeName(Action<commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupChangeNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupChangeNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupRemoveAttributeAction RemoveAttribute(Action<commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupRemoveAttributeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupRemoveAttributeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupSetAttributesAction SetAttributes(Action<commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupSetAttributesAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupSetAttributesAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupSetDescriptionAction SetDescription(Action<commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupSetDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupSetDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupSetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupSetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupSetKeyAction();
            init?.Invoke(t);
            return t;
        }
    }
}
