using commercetools.Api.Models.Reviews;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Api.Models.Reviews.ReviewTransitionStateAction))]
    public interface IReviewTransitionStateAction : IReviewUpdateAction
    {
        IStateResourceIdentifier State { get; set;}
        
        bool Force { get; set;}
    }
}
