using commercetools.Api.Generated.Models.Reviews;
using commercetools.Api.Generated.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Reviews
{
    public interface IReviewTransitionStateAction : IReviewUpdateAction
    {
        IStateResourceIdentifier State { get; set;}
        
        bool Force { get; set;}
    }
}
