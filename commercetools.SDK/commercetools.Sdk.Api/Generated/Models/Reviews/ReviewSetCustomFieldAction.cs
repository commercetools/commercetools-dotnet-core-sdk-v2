using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DiscriminatorValue("setCustomField")]
    public partial class ReviewSetCustomFieldAction : ReviewUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public ReviewSetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}
