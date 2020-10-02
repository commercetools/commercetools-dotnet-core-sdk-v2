using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DiscriminatorValue("setTitle")]
    public partial class ReviewSetTitleAction : ReviewUpdateAction
    {
        public string Title { get; set;}
        public ReviewSetTitleAction()
        { 
           this.Action = "setTitle";
        }
    }
}
