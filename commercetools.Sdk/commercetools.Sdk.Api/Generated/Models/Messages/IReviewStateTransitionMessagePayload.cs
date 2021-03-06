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
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ReviewStateTransitionMessagePayload))]
    public partial interface IReviewStateTransitionMessagePayload : IMessagePayload
    {
        IStateReference OldState { get; set;}
        
        IStateReference NewState { get; set;}
        
        bool OldIncludedInStatistics { get; set;}
        
        bool NewIncludedInStatistics { get; set;}
        
        IReference Target { get; set;}
        
        bool Force { get; set;}
    }
}
