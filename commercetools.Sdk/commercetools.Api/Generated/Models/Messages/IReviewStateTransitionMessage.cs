using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Messages;
using commercetools.Api.Generated.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Messages
{
    public interface IReviewStateTransitionMessage : IMessage
    {
        IStateReference OldState { get; set;}
        
        IStateReference NewState { get; set;}
        
        bool OldIncludedInStatistics { get; set;}
        
        bool NewIncludedInStatistics { get; set;}
        
        IReference Target { get; set;}
        
        bool Force { get; set;}
    }
}
