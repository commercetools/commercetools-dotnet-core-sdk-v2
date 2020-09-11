using commercetools.Api.Models.Reviews;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Reviews
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(ReviewSetAuthorNameAction), "setAuthorName")]
    [JsonSubtypes.KnownSubType(typeof(ReviewSetCustomFieldAction), "setCustomField")]
    [JsonSubtypes.KnownSubType(typeof(ReviewSetCustomTypeAction), "setCustomType")]
    [JsonSubtypes.KnownSubType(typeof(ReviewSetCustomerAction), "setCustomer")]
    [JsonSubtypes.KnownSubType(typeof(ReviewSetKeyAction), "setKey")]
    [JsonSubtypes.KnownSubType(typeof(ReviewSetLocaleAction), "setLocale")]
    [JsonSubtypes.KnownSubType(typeof(ReviewSetRatingAction), "setRating")]
    [JsonSubtypes.KnownSubType(typeof(ReviewSetTargetAction), "setTarget")]
    [JsonSubtypes.KnownSubType(typeof(ReviewSetTextAction), "setText")]
    [JsonSubtypes.KnownSubType(typeof(ReviewSetTitleAction), "setTitle")]
    [JsonSubtypes.KnownSubType(typeof(ReviewTransitionStateAction), "transitionState")]
    public abstract class ReviewUpdateAction 
    {
        public string Action { get; set;}
    }
}
