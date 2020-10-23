using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    public  partial class ReviewSetTextAction : IReviewSetTextAction
    {
        public string Action { get; set;}
        
        public string Text { get; set;}
        public ReviewSetTextAction()
        { 
           this.Action = "setText";
        }
    }
}
