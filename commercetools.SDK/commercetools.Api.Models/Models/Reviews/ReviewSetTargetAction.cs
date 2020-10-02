using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DiscriminatorValue("setTarget")]
    public partial class ReviewSetTargetAction : ReviewUpdateAction
    {
        public Object Target { get; set;}
        public ReviewSetTargetAction()
        { 
           this.Action = "setTarget";
        }
    }
}
