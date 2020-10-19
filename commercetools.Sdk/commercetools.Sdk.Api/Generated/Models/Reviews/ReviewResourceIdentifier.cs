using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DiscriminatorValue("review")]
    public partial class ReviewResourceIdentifier : ResourceIdentifier
    {
        public ReviewResourceIdentifier()
        { 
           this.TypeId = "review";
        }
    }
}
