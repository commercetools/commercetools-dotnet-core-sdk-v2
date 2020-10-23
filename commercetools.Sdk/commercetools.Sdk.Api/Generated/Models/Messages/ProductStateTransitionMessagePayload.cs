using commercetools.Api.Models.Messages;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public  partial class ProductStateTransitionMessagePayload : IProductStateTransitionMessagePayload
    {
        public string Type { get; set;}
        
        public IStateReference State { get; set;}
        
        public bool Force { get; set;}
        public ProductStateTransitionMessagePayload()
        { 
           this.Type = "ProductStateTransition";
        }
    }
}
