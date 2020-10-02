using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DiscriminatorValue("setText")]
    public partial class ReviewSetTextAction : ReviewUpdateAction
    {
        public string Text { get; set;}
        public ReviewSetTextAction()
        { 
           this.Action = "setText";
        }
    }
}
