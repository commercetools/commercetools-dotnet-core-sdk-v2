using commercetools.Base.CustomAttributes;


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
    public partial interface IReviewUpdateAction : commercetools.Sdk.Api.Models.IResourceUpdateAction<IReviewUpdateAction>
    {
        new string Action { get; set; }
    }
}
