using commercetools.Api.Models.Reviews;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DiscriminatorValue("transitionState")]
    public partial class ReviewTransitionStateAction : ReviewUpdateAction
    {
        public StateResourceIdentifier State { get; set;}
        
        public bool Force { get; set;}
        public ReviewTransitionStateAction()
        { 
           this.Action = "transitionState";
        }
    }
}
