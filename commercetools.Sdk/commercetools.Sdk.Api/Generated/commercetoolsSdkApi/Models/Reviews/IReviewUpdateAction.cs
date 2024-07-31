using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Reviews
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Reviews.ReviewUpdateAction))]
    [SubTypeDiscriminator("setAuthorName", typeof(commercetools.Sdk.Api.Models.Reviews.ReviewSetAuthorNameAction))]
    [SubTypeDiscriminator("setCustomer", typeof(commercetools.Sdk.Api.Models.Reviews.ReviewSetCustomerAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.Reviews.ReviewSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.Reviews.ReviewSetCustomTypeAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.Reviews.ReviewSetKeyAction))]
    [SubTypeDiscriminator("setLocale", typeof(commercetools.Sdk.Api.Models.Reviews.ReviewSetLocaleAction))]
    [SubTypeDiscriminator("setRating", typeof(commercetools.Sdk.Api.Models.Reviews.ReviewSetRatingAction))]
    [SubTypeDiscriminator("setTarget", typeof(commercetools.Sdk.Api.Models.Reviews.ReviewSetTargetAction))]
    [SubTypeDiscriminator("setText", typeof(commercetools.Sdk.Api.Models.Reviews.ReviewSetTextAction))]
    [SubTypeDiscriminator("setTitle", typeof(commercetools.Sdk.Api.Models.Reviews.ReviewSetTitleAction))]
    [SubTypeDiscriminator("transitionState", typeof(commercetools.Sdk.Api.Models.Reviews.ReviewTransitionStateAction))]
    public partial interface IReviewUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.Reviews.ReviewSetAuthorNameAction SetAuthorName(Action<commercetools.Sdk.Api.Models.Reviews.ReviewSetAuthorNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Reviews.ReviewSetAuthorNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Reviews.ReviewSetCustomerAction SetCustomer(Action<commercetools.Sdk.Api.Models.Reviews.ReviewSetCustomerAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Reviews.ReviewSetCustomerAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Reviews.ReviewSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.Reviews.ReviewSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Reviews.ReviewSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Reviews.ReviewSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.Reviews.ReviewSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Reviews.ReviewSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Reviews.ReviewSetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.Reviews.ReviewSetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Reviews.ReviewSetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Reviews.ReviewSetLocaleAction SetLocale(Action<commercetools.Sdk.Api.Models.Reviews.ReviewSetLocaleAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Reviews.ReviewSetLocaleAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Reviews.ReviewSetRatingAction SetRating(Action<commercetools.Sdk.Api.Models.Reviews.ReviewSetRatingAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Reviews.ReviewSetRatingAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Reviews.ReviewSetTargetAction SetTarget(Action<commercetools.Sdk.Api.Models.Reviews.ReviewSetTargetAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Reviews.ReviewSetTargetAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Reviews.ReviewSetTextAction SetText(Action<commercetools.Sdk.Api.Models.Reviews.ReviewSetTextAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Reviews.ReviewSetTextAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Reviews.ReviewSetTitleAction SetTitle(Action<commercetools.Sdk.Api.Models.Reviews.ReviewSetTitleAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Reviews.ReviewSetTitleAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Reviews.ReviewTransitionStateAction TransitionState(Action<commercetools.Sdk.Api.Models.Reviews.ReviewTransitionStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Reviews.ReviewTransitionStateAction();
            init?.Invoke(t);
            return t;
        }
    }
}
