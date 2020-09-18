using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ReviewStateTransition")]
    public class ReviewStateTransitionMessagePayload : MessagePayload
    {
        public StateReference OldState { get; set;}
        
        public StateReference NewState { get; set;}
        
        public bool OldIncludedInStatistics { get; set;}
        
        public bool NewIncludedInStatistics { get; set;}
        
        public Reference Target { get; set;}
        
        public bool Force { get; set;}
    }
}
