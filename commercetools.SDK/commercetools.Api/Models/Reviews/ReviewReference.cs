using commercetools.Api.Models.Common;
using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DiscriminatorValue("review")]
    public partial class ReviewReference : Reference
    {
        public Review Obj { get; set;}
        public ReviewReference()
        { 
           this.TypeId = "review";
        }
    }
}
