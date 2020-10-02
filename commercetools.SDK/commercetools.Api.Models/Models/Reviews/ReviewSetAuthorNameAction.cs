using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DiscriminatorValue("setAuthorName")]
    public partial class ReviewSetAuthorNameAction : ReviewUpdateAction
    {
        public string AuthorName { get; set;}
        public ReviewSetAuthorNameAction()
        { 
           this.Action = "setAuthorName";
        }
    }
}
