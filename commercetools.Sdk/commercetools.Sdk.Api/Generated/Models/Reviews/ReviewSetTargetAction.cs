using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    public partial class ReviewSetTargetAction : IReviewSetTargetAction
    {
        public string Action { get; set;}
        
        public Object Target { get; set;}
        public ReviewSetTargetAction()
        { 
           this.Action = "setTarget";
        }
    }
}
