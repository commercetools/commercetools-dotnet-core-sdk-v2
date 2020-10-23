using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    public  partial class ReviewSetAuthorNameAction : IReviewSetAuthorNameAction
    {
        public string Action { get; set;}
        
        public string AuthorName { get; set;}
        public ReviewSetAuthorNameAction()
        { 
           this.Action = "setAuthorName";
        }
    }
}
