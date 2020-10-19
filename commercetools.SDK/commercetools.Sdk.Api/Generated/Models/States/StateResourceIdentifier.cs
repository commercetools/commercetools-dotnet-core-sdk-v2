using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DiscriminatorValue("state")]
    public partial class StateResourceIdentifier : ResourceIdentifier
    {
        public StateResourceIdentifier()
        { 
           this.TypeId = "state";
        }
    }
}
