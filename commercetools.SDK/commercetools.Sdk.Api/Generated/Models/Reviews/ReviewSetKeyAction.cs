using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DiscriminatorValue("setKey")]
    public partial class ReviewSetKeyAction : ReviewUpdateAction
    {
        public string Key { get; set;}
        public ReviewSetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}
