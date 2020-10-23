using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public  partial class ReviewStateTransitionMessagePayload : IReviewStateTransitionMessagePayload
    {
        public string Type { get; set;}
        
        public IStateReference OldState { get; set;}
        
        public IStateReference NewState { get; set;}
        
        public bool OldIncludedInStatistics { get; set;}
        
        public bool NewIncludedInStatistics { get; set;}
        
        public IReference Target { get; set;}
        
        public bool Force { get; set;}
        public ReviewStateTransitionMessagePayload()
        { 
           this.Type = "ReviewStateTransition";
        }
    }
}
