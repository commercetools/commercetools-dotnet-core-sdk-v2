using commercetools.Api.Models.Messages;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ProductStateTransition")]
    public partial class ProductStateTransitionMessagePayload : MessagePayload
    {
        public StateReference State { get; set;}
        
        public bool Force { get; set;}
        public ProductStateTransitionMessagePayload()
        { 
           this.Type = "ProductStateTransition";
        }
    }
}
