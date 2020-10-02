using commercetools.Api.Models.Reviews;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DiscriminatorValue("setCustomType")]
    public partial class ReviewSetCustomTypeAction : ReviewUpdateAction
    {
        public TypeResourceIdentifier Type { get; set;}
        
        public FieldContainer Fields { get; set;}
        public ReviewSetCustomTypeAction()
        { 
           this.Action = "setCustomType";
        }
    }
}
