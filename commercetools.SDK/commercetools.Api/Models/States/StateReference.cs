using commercetools.Api.Models.Common;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DiscriminatorValue("state")]
    public partial class StateReference : Reference
    {
        public State Obj { get; set;}
        public StateReference()
        { 
           this.TypeId = "state";
        }
    }
}
