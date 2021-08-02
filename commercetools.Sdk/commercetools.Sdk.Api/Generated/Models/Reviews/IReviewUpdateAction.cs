using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Reviews.ReviewUpdateAction))]
    [SubTypeDiscriminator("setAuthorName", typeof(commercetools.Api.Models.Reviews.ReviewSetAuthorNameAction))]
    [SubTypeDiscriminator("setCustomer", typeof(commercetools.Api.Models.Reviews.ReviewSetCustomerAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Api.Models.Reviews.ReviewSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Api.Models.Reviews.ReviewSetCustomTypeAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Api.Models.Reviews.ReviewSetKeyAction))]
    [SubTypeDiscriminator("setLocale", typeof(commercetools.Api.Models.Reviews.ReviewSetLocaleAction))]
    [SubTypeDiscriminator("setRating", typeof(commercetools.Api.Models.Reviews.ReviewSetRatingAction))]
    [SubTypeDiscriminator("setTarget", typeof(commercetools.Api.Models.Reviews.ReviewSetTargetAction))]
    [SubTypeDiscriminator("setText", typeof(commercetools.Api.Models.Reviews.ReviewSetTextAction))]
    [SubTypeDiscriminator("setTitle", typeof(commercetools.Api.Models.Reviews.ReviewSetTitleAction))]
    [SubTypeDiscriminator("transitionState", typeof(commercetools.Api.Models.Reviews.ReviewTransitionStateAction))]
    public partial interface IReviewUpdateAction 
    {
        string Action { get; set;}
    }
}
